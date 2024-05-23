using Microsoft.AspNetCore.Mvc;
using Reciicer.Models;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;
using Reciicer.Service.Reciclagem;


namespace Reciicer.Controllers
{
    public class ReciclagemController : Controller
    {

        private readonly IReciclagemRepository _reciclagemRepository;
        private readonly ReciclagemService _reciclagemService;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMaterialRepository _materialRepository;

        public ReciclagemController(IReciclagemRepository reciclagemRepository, 
                                    IClienteRepository clienteRepository,
                                    IMaterialRepository materialRepository,
                                    ReciclagemService reciclagemService)
        {
           _reciclagemRepository = reciclagemRepository; 
           _clienteRepository = clienteRepository;
           _materialRepository = materialRepository;
           _reciclagemService = reciclagemService;
        }

        public IActionResult Index()
        {   
            var reciclagens = _reciclagemRepository.ListarReciclagem();

            return View(reciclagens);
        }

        [HttpGet]
        public IActionResult Create()
        {

            var clientes = _clienteRepository.ListarCliente();
            var materiais = _materialRepository.ListarMaterial();

            var reciclagemCreate = new ReciclagemCreateViewModel{
                Clientes = clientes,
                Materiais = materiais
            };

            return View(reciclagemCreate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ReciclagemViewModel reciclagemViewModel)
        {       
         
            _reciclagemService.EfetuarRecilagem(reciclagemViewModel);
                
            return RedirectToAction("Index");
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateManyMateriais(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {


            _reciclagemService.EfetuarRecilagemMuitosMateriais(reciclagemCreateViewModel);
                
            return RedirectToAction("Index");
           
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _reciclagemRepository.DetalharReciclagem(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var reciclagem = _reciclagemRepository.ObterReciclagemPorId(id);

            return View(reciclagem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Reciclagem reciclagem)
        { 
            _reciclagemRepository.AtualizarReciclagem(reciclagem);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _reciclagemRepository.ExcluirReciclagem(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CarregarSelectMateriais(int count)
        {   
            var clientes = _clienteRepository.ListarCliente();
            var materiais = _materialRepository.ListarMaterial();

            var reciclagemCreate = new ReciclagemCreateViewModel{
                Clientes = clientes,
                Materiais = materiais,
                QtdMateriais = count
                 
            };

            return PartialView("_ReciclagemMaterialListPartial", reciclagemCreate);
        }
    }
}