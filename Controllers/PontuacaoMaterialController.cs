using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Models.PontuacaoMaterialViewModels;
using Reciicer.Repository.Interface;
using Reciicer.Service.TipoMaterial;

namespace Reciicer.Controllers
{
    public class PontuacaoMaterialController : Controller
    {
        private readonly IPontuacaoMaterialRepository _pontuacaoMateriarepository;

        private readonly TipoMaterialService _tipoMaterialService;

        public PontuacaoMaterialController(IPontuacaoMaterialRepository pontuacaoMaterialRepository,
                                           TipoMaterialService tipoMaterialService)
        {
            _pontuacaoMateriarepository = pontuacaoMaterialRepository;
            _tipoMaterialService = tipoMaterialService;
        }

        public IActionResult Index()
        {   

            return View( _pontuacaoMateriarepository.ListarPontuacaoMaterial());
        }

        [HttpGet]
        public IActionResult Create()
        {

            var pontuacaoMaterial = new PontuacaoMaterialCreateViewModel{
                TipoMaterial = _tipoMaterialService.PopularSelect()
            };

            return View(pontuacaoMaterial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PontuacaoMaterial pontuacaoMaterial)
        {
            _pontuacaoMateriarepository.RegistrarPontuacaoMaterial(pontuacaoMaterial);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _pontuacaoMateriarepository.ObterPontuacaoMaterialPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        { 
            var pontuacaoMaterial = _pontuacaoMateriarepository.ObterPontuacaoMaterialPorId(id);

            var pontuacaoMaterialCreateViewModel = new PontuacaoMaterialCreateViewModel{
                TipoMaterial = _tipoMaterialService.PopularSelect(),
                PontuacaoMaterial =  pontuacaoMaterial
            };

            return View(pontuacaoMaterialCreateViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(PontuacaoMaterialCreateViewModel pontuacaoMaterialCreateViewModel)
        { 
            _pontuacaoMateriarepository.AtualizarPontuacaoMaterial(pontuacaoMaterialCreateViewModel.PontuacaoMaterial);

            return RedirectToAction("Index");
        }   
          
        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _pontuacaoMateriarepository.ExcluirPontuacaoMaterial(id);

            return RedirectToAction("Index");
        }

    }
}