
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;

namespace Reciicer.Controllers
{
    
    public class ClienteController : Controller
    {

        
        private readonly ClienteService _clienteService;
        private readonly IEmailService _emailService;
        


        public ClienteController(ClienteService clienteService, IEmailService emailService)
        {
            
            _clienteService = clienteService;
            _emailService = emailService;
            
        }

        public IActionResult Index()
        {
 
            return View(_clienteService.ListarClientesComPontuacaoTotal());
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
           
            _clienteService.RegistrarCliente(cliente);

            return RedirectToAction("Index");
         }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            
            // var mensagem = "HelLo World!!!<br> Teste Email =D";

            // _emailService.EnviarEmail("guhstudante@gmail.com", "Reciicer", mensagem);
            
            return View(_clienteService.ObterClientePorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var cliente = _clienteService.ObterClientePorId(id);

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // evitar crsf
        public IActionResult Update(Cliente cliente)
        {
            _clienteService.AtualizarCliente(cliente);

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            _clienteService.ExcluirCliente(id);

            return RedirectToAction("Index");
        }

        // [HttpGet]
        // public IActionResult InformarClientePremiacaoFiltro(int? nivelId )
        // {   
      
        //     var model =  new ClienteNivelPremiacaoViewModel{
        //         Clientes = nivelId.HasValue ? _clienteService.ObterClientesPremiacao().Where(c => c.NivelId == nivelId) : 
        //                                       _clienteService.ObterClientesPremiacao(),

        //         Niveis = _nivelService.PopularSelect().Where( n => n.Id != 1)
        //     };

        //     return View(model);
        // }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnviarEmailClientePremiacao(string email, int nivelId)
        { 
            
            var emailEnviado =  _emailService.EnviarEmail("guhstudante@gmail.com", "Premiação Disponível",_emailService.MontarEmailBody());

            if(emailEnviado)
            {
               TempData["Mensagem"] = $"Email para {email} enviado!";
            }
            else
            {
                TempData["Mensagem"] = $"Falha ao enviar o email para {email}.";
            }

            return RedirectToAction("InformarClientePremiacaoFiltro", new {nivelId});
        }

        // [HttpGet]
        // public IActionResult InformarClientePremiacao()
        // { 
        //     var model = _clienteService.ObterClientesPremiacao();

        //     return View(model);
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken] 
        // public async Task<IActionResult> InformarClientePremiacao(string email)
        // { 

        //     await _emailService.EnviarEmailAsync("guhstudante@gmail.com", "Premiação Disponível",_emailService.MontarEmailBody());

        //     return RedirectToAction("InformarClientePremiacao");
        // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}