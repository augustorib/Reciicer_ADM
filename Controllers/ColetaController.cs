using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.ColetaViewModels;
using Reciicer.Models.Entities;
using Reciicer.Service.Coleta;
using Reciicer.Service.Material;
using Reciicer.Service.Material_Coleta;


namespace Reciicer.Controllers
{
    
    public class ColetaController : Controller
    {
        private readonly ColetaService _coletaService;
        
        private readonly MaterialService _materialService;
        private readonly Material_ColetaService _material_ColetaService;

        public ColetaController(ColetaService coletaService, MaterialService materialService, Material_ColetaService  material_ColetaService)
        {
            _coletaService = coletaService;
            _materialService = materialService;
            _material_ColetaService = material_ColetaService;
        }

        public IActionResult Index()
        {
            return View(_coletaService.ListarColeta());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var coletaCreate = _coletaService.ObterColetaCreateViewModel();

            return View(coletaCreate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarColetaCliente(ColetaCreateViewModel coletaCreateViewModel)
        {       
            //Cria a Reciclagem para o cliente
            _coletaService.EfetuarColetaCliente(coletaCreateViewModel);

            var coletaCreateViewCliente =_coletaService.ObterColetaCreateViewModelComUltimaColeta(coletaCreateViewModel.ClienteId);
    
            return View("Create", coletaCreateViewCliente);
        }

        //Carregar drop Material de acordo com o Tipo Material selecionado
        // dinamicamente na view Reciclagem/Create
        [HttpGet]
        public JsonResult ObterMaterialByTipoMaterialId(int tipoMaterialId)
        {
            return Json(_materialService.PopularSelectFiltrandoPorTipoMaterialId(tipoMaterialId));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarColetaTabela(ColetaCreateViewModel coletaCreateViewModel)
        {
                // var coletaCliente = _reciclagemService.ObterClienteUltimaReciclagem(coletaCreateViewModel.ClienteId);

                // var tipoMateriais = _materialRepository.ListarMaterial();
                
                //  _coletaService.EfetuarColetaMaterial(coletaCreateViewModel);

                // coletaCreateViewModel.Materiais = materiais;
                // coletaCreateViewModel.Coleta = coletaCliente;
                // coletaCreateViewModel.Material_coleta = _material_coletaRepository.ListarMaterialColetaPorcoletaId(coletaCliente.Id);
                // coletaCreateViewModel.coletaId = coletaCliente.Id;

                var materialColeta =  new Material_Coleta{
                    Peso = coletaCreateViewModel.Peso,
                    Quantidade = coletaCreateViewModel.Quantidade,
                    ColetaId = coletaCreateViewModel.ColetaId,
                    MaterialId = coletaCreateViewModel.MaterialId
                };

                var viewModel = _coletaService.ObterColetaCreateViewModelComMaterialColeta(coletaCreateViewModel.ClienteId, materialColeta);

                return View("Create", viewModel);          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarMaterialColeta(int id, int clienteId)
        {

            _material_ColetaService.ExcluirMaterialColeta(id);

            // var reciclagemCliente = _reciclagemService.ObterClienteUltimaReciclagem(clienteId);
            // var materiais = _materialRepository.ListarMaterial();

            // var reciclagemCreateViewModel = new ReciclagemCreateViewModel{
            //     Materiais = materiais,
            //     Reciclagem = reciclagemCliente,
            //     Material_Reciclagem = _material_ReciclagemRepository.ListarMaterialReciclagemPorReciclagemId(reciclagemCliente.Id),
            //     ClienteId = reciclagemCliente.ClienteId,
            //     ReciclagemId = reciclagemCliente.Id
            
            // };
            var coletaCreateViewModel = _coletaService.ObterColetaCreateViewModelComMaterialColeta(clienteId);
            
            return View("Create", coletaCreateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalcularPontuacaoColeta(int coletaId)
        {               
            _coletaService.CalcularPontuacaoColeta(coletaId);

            return RedirectToAction("Index");
        }
    }
}