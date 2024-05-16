
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;

namespace Reciicer.Controllers
{
    
    public class ClienteController : Controller
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly ClienteService _clienteService;

        public ClienteController(IClienteRepository clienteRepository, ClienteService clienteService)
        {
            _clienteRepository = clienteRepository;
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            //var clientes = _clienteRepository.ListarCliente();
 
            return View(_clienteService.CalcularPontuacaoTotalCliente());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // evitar crsf
        public IActionResult Create(Cliente cliente)
        {
           
            _clienteRepository.RegistrarCliente(cliente);

            return RedirectToAction("Index");
         }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View(_clienteRepository.DetalharCliente(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var cliente = _clienteRepository.ObterClientePorId(id);

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // evitar crsf
        public IActionResult Update(Cliente cliente)
        {
            _clienteRepository.AtualizarCliente(cliente);

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            _clienteRepository.ExcluirCliente(id);

            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}