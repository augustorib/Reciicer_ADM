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
            //Cria a Coleta para o cliente
            _coletaService.EfetuarColetaCliente(coletaCreateViewModel);

            var coletaCreateViewCliente =_coletaService.ObterColetaCreateViewModelComUltimaColeta(coletaCreateViewModel.ClienteId);
    
            return View("Create", coletaCreateViewCliente);
            
        }

        //Carregar drop Material de acordo com o Tipo Material selecionado
        // dinamicamente na view Coleta/Create
        [HttpGet]
        public JsonResult ObterMaterialByTipoMaterialId(int tipoMaterialId)
        {
            return Json(_materialService.PopularSelectFiltrandoPorTipoMaterialId(tipoMaterialId));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarColetaTabela(ColetaCreateViewModel coletaCreateViewModel)
        {
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

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View(_coletaService.ObterColetaReadViewModel(id));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_coletaService.ObterUpdateViewModel(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AtualizarColetaTabela(ColetaUpdateViewModel viewModel)
        {
            var materialColeta = new Material_Coleta
            {
                ColetaId = viewModel.ColetaId,
                MaterialId = viewModel.MaterialId,
                Peso = viewModel.Peso,
                Quantidade = viewModel.Quantidade
            };

            _material_ColetaService.RegistrarMaterialColeta(materialColeta);

            var viewModelUpdate = _coletaService.ObterUpdateViewModel(viewModel.ColetaId);

            return View("Update", viewModelUpdate);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoverMaterialColetaTabelaViewUpdate(int id, int coletaId)
        {
            _material_ColetaService.ExcluirMaterialColeta(id);

            var viewModel = _coletaService.ObterUpdateViewModel(coletaId);

            return View("Update", viewModel);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _coletaService.ExcluirColeta(id);

            return RedirectToAction("Index");
        }

    }
}