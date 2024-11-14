using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.TipoMaterial;


namespace Reciicer.Controllers
{
    
    public class TipoMaterialController : Controller
    {
        private readonly TipoMaterialService _tipoMaterialService;

        public TipoMaterialController(TipoMaterialService tipoMaterialService)
        {
            _tipoMaterialService = tipoMaterialService;
        }

        public IActionResult Index()
        {
            return View(_tipoMaterialService.ListarTipoMaterial());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoMaterial tipoMaterial)
        {
            _tipoMaterialService.RegistrarTipoMaterial(tipoMaterial);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _tipoMaterialService.ObterTipoMaterialPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {           
            return View(_tipoMaterialService.ObterTipoMaterialPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(TipoMaterial tipoMaterial)
        { 
            _tipoMaterialService.AtualizarTipoMaterial(tipoMaterial);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _tipoMaterialService.ExcluirTipoMaterial(id);

            return RedirectToAction("Index");
        }
    }
}