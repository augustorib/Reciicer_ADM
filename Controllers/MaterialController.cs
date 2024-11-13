using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.Material;

namespace Reciicer.Controllers
{
    
    public class MaterialController : Controller
    {
        private readonly MaterialService _materialService;

        public MaterialController(MaterialService materialService)
        {
            _materialService = materialService;    
        }

        public IActionResult Index()
        {
            return View(_materialService.ListarMaterial());
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
            _materialService.RegistrarMaterial(material);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View(_materialService.ObterMaterialPorId(id));
        }
        
       [HttpGet]
        public IActionResult Update(int id)
        { 
            return View(_materialService.ObterMaterialPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Material material)
        { 
            _materialService.AtualizarMaterial(material);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _materialService.ExcluirMaterial(id);

            return RedirectToAction("Index");
        }

    }
}