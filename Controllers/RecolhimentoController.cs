using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.Recolhimento;


namespace Reciicer.Controllers
{
    
    public class RecolhimentoController : Controller
    {
        private readonly RecolhimentoService _recolhimentoService;

        public RecolhimentoController(RecolhimentoService recolhimentoService)
        {
            _recolhimentoService = recolhimentoService;
        }

        public IActionResult Index()
        {
            return View(_recolhimentoService.ListarRecolhimento());
        }


        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _recolhimentoService.ObterRecolhimentoPorId(id));
        }
    }
}