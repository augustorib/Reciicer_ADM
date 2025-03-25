using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Models.EstoqueViewModels;
using Reciicer.Service.Estoque;
using Reciicer.Service.EstoqueMaterial;
using Reciicer.Service.PontoColeta;


namespace Reciicer.Controllers
{
    
    public class EstoqueController : Controller
    {
        
        private readonly EstoqueService _estoqueService;
        private readonly PontoColetaService _pontoColetaService;
        private readonly EstoqueMaterialService _estoqueMaterialService;

        public EstoqueController(EstoqueService estoqueService, PontoColetaService pontoColetaService, EstoqueMaterialService estoqueMaterialService)
        {
            _estoqueService = estoqueService;
            _pontoColetaService = pontoColetaService;
            _estoqueMaterialService = estoqueMaterialService;
        }

        public IActionResult Index()
        {
            return View(_estoqueService.ListarEstoque());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var estoqueCreateViewModel = new EstoqueCreateViewModel
            {
                PontoColetas = _pontoColetaService.ListarPontoColeta()
            };

            return View(estoqueCreateViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Estoque estoque)
        {   
            _estoqueService.RegistrarEstoque(estoque);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            var model = new EstoqueReadViewModel(){
                Estoque = _estoqueService.ObterEstoquePorId(id),
                EstoqueMateriais = _estoqueMaterialService.ObterEstoqueMaterialPorEstoqueId(id).Where(em => em.Quantidade != 0 || em.Peso != 0)
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model  =  new EstoqueCreateViewModel(){
                Estoque = _estoqueService.ObterEstoquePorId(id),
                PontoColetas = _pontoColetaService.ListarPontoColeta()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Estoque estoque)
        {
            _estoqueService.AtualizarEstoque(estoque);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _estoqueService.ExcluirEstoque(id);

            return RedirectToAction("Index");
        }


    }
}