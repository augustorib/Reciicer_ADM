using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;


namespace Reciicer.Controllers
{
    public class NivelController : Controller
    {
        private readonly INivelRepository _nivelRepository;

        public NivelController(INivelRepository nivelRepository)
        {
            _nivelRepository = nivelRepository;
        }

        public IActionResult Index()
        {
            return View(_nivelRepository.ListarNivel());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Nivel nivel)
        {
            _nivelRepository.RegistrarNivel(nivel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _nivelRepository.ObterNivelPorId(id));
        }
      
        [HttpGet]
        public IActionResult Update(int id)
        { 
            var nivel = _nivelRepository.ObterNivelPorId(id);

            return View(nivel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Nivel nivel)
        { 
            _nivelRepository.AtualizarNivel(nivel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _nivelRepository.ExcluirNivel(id);

            return RedirectToAction("Index");
        }
    }
}