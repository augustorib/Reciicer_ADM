using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Service.Premiacao;


namespace Reciicer.Controllers
{
    
    public class PremiacaoController : Controller
    {
        private readonly PremiacaoService _premiacaoService;

        public PremiacaoController(PremiacaoService premiacaoService)
        {
            _premiacaoService = premiacaoService;
        }

        public IActionResult Index()
        {
            return View(_premiacaoService.ListarPremiacao());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Premiacao premiacao)
        {
            _premiacaoService.RegistrarPremiacao(premiacao);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _premiacaoService.ObterPremiacaoPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        { 
            var premiacao = _premiacaoService.ObterPremiacaoPorId(id);

            return View("Update", premiacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Premiacao premiacao)
        { 

            _premiacaoService.AtualizarPremiacao(premiacao);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _premiacaoService.ExcluirPremiacao(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PremiacaoCliente(int? premiacaoId)
        { 
            return View(_premiacaoService.MontarViewModelPremiarCliente(premiacaoId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PremiarCliente(int clienteId, int premiacaoId)
        { 
            
            if(clienteId != null && premiacaoId != null)
            {
               var premiacaoRealizada = _premiacaoService.RealizarPremiacao(premiacaoId, clienteId);

               TempData["Mensagem"] = premiacaoRealizada ? "Premiação realizada com sucesso!" : "Erro ao realizar premiação!";
            }

            return RedirectToAction("PremiacaoCliente");
        }

 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}