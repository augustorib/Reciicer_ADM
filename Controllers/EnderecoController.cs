using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.Endereco;


namespace Reciicer.Controllers
{
    
    public class EnderecoController : Controller
    {
        private readonly EnderecoService _enderecoService;

        public EnderecoController(EnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        public IActionResult Index()
        {
            return View(_enderecoService.ListarEndereco());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Endereco endereco)
        {   
            _enderecoService.RegistrarEndereco(endereco);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View(_enderecoService.ObterEnderecoPorId(id));
        }
        
       [HttpGet]
        public IActionResult Update(int id)
        { 
            return View(_enderecoService.ObterEnderecoPorId(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Endereco endereco)
        { 
            _enderecoService.AtualizarEndereco(endereco);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _enderecoService.ExcluirEndereco(id);

            return RedirectToAction("Index");
        }

    }
}