using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;

namespace Reciicer.Controllers
{
    public class PontuacaoMaterialController : Controller
    {
        private readonly IPontuacaoMaterialRepository _pontuacaoMateriarepository;

        public PontuacaoMaterialController(IPontuacaoMaterialRepository pontuacaoMaterialRepository)
        {
            _pontuacaoMateriarepository = pontuacaoMaterialRepository;
        }

        public IActionResult Index()
        {   

            return View( _pontuacaoMateriarepository.ListarPontuacaoMaterial());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PontuacaoMaterial pontuacaoMaterial)
        {
            _pontuacaoMateriarepository.RegistrarPontuacaoMaterial(pontuacaoMaterial);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}