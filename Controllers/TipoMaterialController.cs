using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.TipoMaterialViewModels;
using Reciicer.Repository.Interface;
using Reciicer.Service.Material;


namespace Reciicer.Controllers
{
    public class TipoMaterialController : Controller
    {
        private readonly ITipoMaterialRepository _tipoMaterialRepository;
        private readonly MaterialService _materialService;

        public TipoMaterialController(ITipoMaterialRepository tipoMaterialRepository, MaterialService materialService)
        {
            _tipoMaterialRepository = tipoMaterialRepository;
            _materialService = materialService;
        }

        public IActionResult Index()
        {
    
            return View(_tipoMaterialRepository.ListarTipoMaterial());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var TipoMaterialCreateView = new TipoMaterialCreateView{
                Material = _materialService.PopularSelect()
            };

            return View(TipoMaterialCreateView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoMaterialCreateView tipoMaterialCreateView)
        {   

            var tipoMaterial = tipoMaterialCreateView.TipoMaterial;

            _tipoMaterialRepository.RegistrarTipoMaterial(tipoMaterial);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _tipoMaterialRepository.ObterTipoMaterialPorId(id));
        }
      
    }
}