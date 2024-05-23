using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Controllers
{

    public class MaterialController : Controller
    {
        private readonly IMaterialRepository _materialRepository;

        public MaterialController(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public IActionResult Index()
        {             
            return View(_materialRepository.ListarMaterial());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Material material)
        {
            _materialRepository.RegistrarMaterial(material);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _materialRepository.ObterMaterialPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {           
            return View(_materialRepository.ObterMaterialPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Material material)
        { 
            _materialRepository.AtualizarMaterial(material);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _materialRepository.ExcluirMaterial(id);

            return RedirectToAction("Index");
        }
    }
}