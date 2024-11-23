
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Models.ClienteViewModels;
using Reciicer.Repository.Interface;
using Reciicer.Service.Cliente;
using Reciicer.Service.Premiacao;

namespace Reciicer.Controllers
{
    
    public class ClienteController : Controller
    {

        
        private readonly ClienteService _clienteService;
        private readonly PremiacaoService _premiacaoService;
        private readonly IEmailService _emailService;
        


        public ClienteController(ClienteService clienteService, IEmailService emailService, PremiacaoService premiacaoService)
        {
            
            _clienteService = clienteService;
            _premiacaoService = premiacaoService;
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

        [HttpGet]
        public IActionResult ClientePremiacao(int? premiacaoId )
        {     
            var premiosDisponiveis = _premiacaoService.ListarPremiacao()
                                    .Where(p => p.ClienteId == null)
                                    .ToList();

            var model = new ClientePremiacaoViewModel{
                Clientes = new List<Cliente>(),
                Premiacoes = premiosDisponiveis,
                Premiacao = new Premiacao(),
                PremiacaoId = premiacaoId ?? 0
            };

           if(premiacaoId.HasValue) 
           {
                model.Premiacao = _premiacaoService.ObterPremiacaoPorId(premiacaoId.Value);

                model.Clientes = _clienteService.ListarCliente()
                                 .Where(c => c.PontuacaoTotal >= model.Premiacao.PontuacaoRequerida)
                                 .ToList();

                model.Premiacoes = premiosDisponiveis;
           }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NotificarClientePremiacao(string email, int premiacaoId)
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

            return RedirectToAction("ClientePremiacao", new {premiacaoId});
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