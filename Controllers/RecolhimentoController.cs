using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Models.RecolhimentoViewModels;
using Reciicer.Service.Cooperativa;
using Reciicer.Service.Material_Coleta;
using Reciicer.Service.Recolhimento;


namespace Reciicer.Controllers
{
    
    public class RecolhimentoController : Controller
    {
        private readonly RecolhimentoService _recolhimentoService;
        private readonly CooperativaService _cooperativaService;
        private readonly Material_ColetaService _material_ColetaService;
        private readonly UserManager<UsuarioIdentity> _userManager;

        public RecolhimentoController(RecolhimentoService recolhimentoService,
        CooperativaService cooperativaService,
        Material_ColetaService material_ColetaService,
        UserManager<UsuarioIdentity> userManager)
        {
            _recolhimentoService = recolhimentoService;
            _cooperativaService = cooperativaService;
            _material_ColetaService = material_ColetaService;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            return View(_recolhimentoService.ListarRecolhimento());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new RecolhimentoCreateViewModel(){
                PontoColetaId = (await _userManager.GetUserAsync(User)).PontoColetaId,
                Cooperativas = _cooperativaService.ListarCooperativa(),
                MateriaisTotais = _material_ColetaService.ObterTotaisMaterial()
                
                
            };

            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RecolhimentoCreateViewModel model)
        {          
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Read(int id)
        { 
            return View( _recolhimentoService.ObterRecolhimentoPorId(id));
        }

  
    }
}