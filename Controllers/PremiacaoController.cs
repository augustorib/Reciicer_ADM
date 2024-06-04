using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.PremiacaoViewModels;
using Reciicer.Repository.Interface;
using Reciicer.Models.Entities;
using Reciicer.Service.Nivel;


namespace Reciicer.Controllers
{
    public class PremiacaoController : Controller
    {
        private readonly IPremiacaoRepository _premiacaoRepository;

        private readonly NivelService _nivelService;

        public PremiacaoController(IPremiacaoRepository premiacaoRepository, NivelService nivelService)
        {
           _premiacaoRepository = premiacaoRepository; 
           _nivelService = nivelService;
        }
        
        public IActionResult Index()
        {
            return View(_premiacaoRepository.ListarPremiacao());
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            var premiacaoCreateView = new PremiacaoCreateView{
                Nivel = _nivelService.PopularSelect()
            };

            return View(premiacaoCreateView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PremiacaoCreateView premiacaoCreateView)
        {
            var premiacao = new Premiacao{
                Nome = premiacaoCreateView.Premiacao.Nome,
                Descricao = premiacaoCreateView.Premiacao.Descricao,
                Ativo = premiacaoCreateView.Premiacao.Ativo,
                NivelId = premiacaoCreateView.Premiacao.NivelId
                
            };

            _premiacaoRepository.RegistrarPremiacao(premiacao);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _premiacaoRepository.ObterPremiacaoPorId(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        { 
            var premiacao = _premiacaoRepository.ObterPremiacaoPorId(id);

            var premiacaoUpdateView = new PremiacaoCreateView{
                Nivel = _nivelService.PopularSelect(),
                Premiacao = premiacao
            };

            return View("Update", premiacaoUpdateView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(PremiacaoCreateView premiacaoCreateView)
        { 
            var premiacao = new Premiacao{
                Id = premiacaoCreateView.Premiacao.Id,
                Nome = premiacaoCreateView.Premiacao.Nome,
                Descricao = premiacaoCreateView.Premiacao.Descricao,
                Ativo = premiacaoCreateView.Premiacao.Ativo,
                NivelId = premiacaoCreateView.Premiacao.NivelId
            };

            _premiacaoRepository.AtualizarPremiacao(premiacao);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        { 
             _premiacaoRepository.ExcluirPremiacao(id);

            return RedirectToAction("Index");
        }
    }
}