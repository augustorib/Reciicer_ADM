using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Models.RecolhimentoViewModels;
using Reciicer.Service.Cooperativa;
using Reciicer.Service.Estoque;
using Reciicer.Service.EstoqueMaterial;
using Reciicer.Service.Recolhimento;
using Reciicer.Service.RecolhimentoEstoqueMaterial;


namespace Reciicer.Controllers
{
    public class RecolhimentoController : Controller
    {
        private readonly RecolhimentoService _recolhimentoService;
        private readonly RecolhimentoEstoqueMaterialService _recolhimentoEstoqueMaterialService;
        private readonly EstoqueMaterialService _estoqueMaterialService;
        private readonly CooperativaService _cooperativaService;
        private readonly EstoqueService _estoqueService;

        public RecolhimentoController(RecolhimentoService recolhimentoService,
        RecolhimentoEstoqueMaterialService recolhimentoEstoqueMaterialService,
        EstoqueMaterialService estoqueMaterialService,
        CooperativaService cooperativaService,
        EstoqueService estoqueService)
        {
            _recolhimentoService = recolhimentoService;
            _recolhimentoEstoqueMaterialService = recolhimentoEstoqueMaterialService;
            _estoqueMaterialService = estoqueMaterialService;
            _cooperativaService = cooperativaService;
            _estoqueService = estoqueService;
    
        }


        public IActionResult Index()
        {
            return View(_recolhimentoService.ListarRecolhimento());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new RecolhimentoCreateViewModel(){
                Cooperativas = _cooperativaService.ListarCooperativa(),
                EstoqueMateriais = _estoqueMaterialService.ListarEstoqueMaterial().Where(em => em.Quantidade != 0 || em.Peso != 0)            
                
            };

            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RecolhimentoCreateViewModel model)
        {          
                     
            _recolhimentoService.RegistrarRecolhimento(model.Recolhimento!);
            
            var ultimoRecolhimento = _recolhimentoService.ObterUltimoRecolhimento();
            
            _recolhimentoEstoqueMaterialService.RegistrarRecolhimentoEstoqueMaterial(model.RecolhimentoEstoqueMateriais!.ToList(), ultimoRecolhimento.Id);

           
            _estoqueService.RemoverMaterialEstoque(model.RecolhimentoEstoqueMateriais!.ToList());

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _recolhimentoService.ObterRecolhimentoPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            return View(_recolhimentoService.ObterRecolhimentoPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public IActionResult Update(Recolhimento recolhimento)
        {
            _recolhimentoEstoqueMaterialService.AtualizarRecolhimentoEstoqueMaterial(recolhimento.RecolhimentoEstoqueMateriais!.ToList());

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _recolhimentoService.ExcluirRecolhimento(id);

            return RedirectToAction("Index");
        }
    }
}