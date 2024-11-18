using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.PontoColeta;


namespace Reciicer.Controllers
{
    
    public class PontoColetaController : Controller
    {
        private readonly PontoColetaService _pontoColetaService;

        public PontoColetaController(PontoColetaService pontoColetaService)
        {
            _pontoColetaService = pontoColetaService;
        }

        public IActionResult Index()
        {
            return View(_pontoColetaService.ListarPontoColeta());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PontoColeta pontoColeta)
        {   
            _pontoColetaService.RegistrarPontoColeta(pontoColeta);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View(_pontoColetaService.ObterPontoColetaPorId(id));
        }
        
       [HttpGet]
        public IActionResult Update(int id)
        { 
            return View(_pontoColetaService.ObterPontoColetaPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(PontoColeta pontoColeta)
        { 
            _pontoColetaService.AtualizarPontoColeta(pontoColeta);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _pontoColetaService.ExcluirPontoColeta(id);

            return RedirectToAction("Index");
        }

    }
}