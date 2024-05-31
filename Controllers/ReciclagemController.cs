using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Reciicer.Models;
using Reciicer.Models.Entities;
using Reciicer.Repository.Interface;
using Reciicer.Service.Reciclagem;
using Reciicer.Service.TipoMaterial;


namespace Reciicer.Controllers
{
    public class ReciclagemController : Controller
    {

        private readonly IReciclagemRepository _reciclagemRepository;
        private readonly ReciclagemService _reciclagemService;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMaterialRepository _materialRepository;
        private readonly TipoMaterialService _tipoMaterialService;
        private readonly IMaterial_ReciclagemRepository _material_ReciclagemRepository;

        public ReciclagemController(IReciclagemRepository reciclagemRepository, 
                                    IClienteRepository clienteRepository,
                                    IMaterialRepository materialRepository,
                                    ReciclagemService reciclagemService,
                                    TipoMaterialService tipoMaterialService,
                                    IMaterial_ReciclagemRepository material_ReciclagemRepository)
        {
           _reciclagemRepository = reciclagemRepository; 
           _clienteRepository = clienteRepository;
           _materialRepository = materialRepository;
           _reciclagemService = reciclagemService;
           _tipoMaterialService = tipoMaterialService;
           _material_ReciclagemRepository = material_ReciclagemRepository;
           
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

        //Carregar drop TipoMaterial de acordo com o Material selecionado
        // dinamicamente na view Reciclagem/Create
        [HttpGet]
        public JsonResult ObterTipoMaterialByMaterialId(int materialId)
        {
            return Json(_tipoMaterialService.PopularSelectFiltrandoPorMaterialId(materialId));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarReciclagemCliente(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {       
                //Cria a Reciclagem para o cliente
                _reciclagemService.EfetuarRecilagemCliente(reciclagemCreateViewModel);

                var materiais = _materialRepository.ListarMaterial();     
                reciclagemCreateViewModel.Materiais = materiais;

               
                

                reciclagemCreateViewModel.Reciclagem = _reciclagemService.ObterClienteUltimaReciclagem(reciclagemCreateViewModel.ClienteId);

                var reciclagemId = reciclagemCreateViewModel.Reciclagem.Id;
                reciclagemCreateViewModel.ReciclagemId = reciclagemId;

            return View("Create", reciclagemCreateViewModel);
        }

        //Adiocionar material na tabela da view Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarReciclagemTabela(ReciclagemCreateViewModel reciclagemCreateViewModel)
        {
                var reciclagemCliente = _reciclagemService.ObterClienteUltimaReciclagem(reciclagemCreateViewModel.ClienteId);

                var materiais = _materialRepository.ListarMaterial();
                
                 _reciclagemService.EfetuarReciclagemMaterial(reciclagemCreateViewModel);

                reciclagemCreateViewModel.Materiais = materiais;
                reciclagemCreateViewModel.Reciclagem = reciclagemCliente;
                reciclagemCreateViewModel.Material_Reciclagem = _material_ReciclagemRepository.ListarMaterialReciclagemPorReciclagemId(reciclagemCliente.Id);
                reciclagemCreateViewModel.ReciclagemId = reciclagemCliente.Id;

                return View("Create", reciclagemCreateViewModel);          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarMaterialReciclagem(int id, int clienteId)
        {

            _material_ReciclagemRepository.ExcluirMaterialReciclagem(id);

            var reciclagemCliente = _reciclagemService.ObterClienteUltimaReciclagem(clienteId);
            var materiais = _materialRepository.ListarMaterial();

            var reciclagemCreateViewModel = new ReciclagemCreateViewModel{
                Materiais = materiais,
                Reciclagem = reciclagemCliente,
                Material_Reciclagem = _material_ReciclagemRepository.ListarMaterialReciclagemPorReciclagemId(reciclagemCliente.Id),
                ClienteId = reciclagemCliente.ClienteId,
                ReciclagemId = reciclagemCliente.Id
            
            };
            
            return View("Create", reciclagemCreateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalcularPontuacaoReciclagem(int reciclagemId)
        {
                    
            _reciclagemService.CalcularPontuacaoReciclagem(reciclagemId);

            return RedirectToAction("Index");
        }

    }

}