using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.Cooperativa;


namespace Reciicer.Controllers
{
    
    public class CooperativaController : Controller
    {
        private readonly CooperativaService _cooperativaService;
        public CooperativaController(CooperativaService cooperativaService)
        {
            _cooperativaService = cooperativaService;
        }

        public IActionResult Index()
        {
            return View(_cooperativaService.ListarCooperativa());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cooperativa cooperativa)
        {   
            _cooperativaService.RegistrarCooperativa(cooperativa);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _cooperativaService.ObterCooperativaPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var cooperativa = _cooperativaService.ObterCooperativaPorId(id);

            return View(cooperativa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Cooperativa cooperativa)
        {
            _cooperativaService.AtualizarCooperativa(cooperativa);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _cooperativaService.ExcluirCooperativa(id);

            return RedirectToAction("Index");
        }
    }
}