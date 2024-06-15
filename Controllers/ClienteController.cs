
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
        private readonly IEmailService _emailService;

        public ClienteController(IClienteRepository clienteRepository, ClienteService clienteService, IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _clienteService = clienteService;
            _emailService = emailService;
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
            
            var mensagem = "HelLo World!!!<br> Teste Email =D";

            _emailService.EnviarEmail("guhstudante@gmail.com", "Reciicer", mensagem);
            
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