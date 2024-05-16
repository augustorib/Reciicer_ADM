using Microsoft.AspNetCore.Mvc;
using Reciicer.Repository.Interface;


namespace Reciicer.Controllers
{
    public class ReciclagemController : Controller
    {

        private readonly IReciclagemRepository _reciclagemRepository;

        public ReciclagemController(IReciclagemRepository reciclagemRepository)
        {
           _reciclagemRepository = reciclagemRepository; 
        }

        public IActionResult Index()
        {   
            var reciclagens = _reciclagemRepository.ListarReciclagem();

            return View(reciclagens);
        }

    }
}