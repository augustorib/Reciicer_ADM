using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models;
using Reciicer.Models.HomeViewModels;
using Reciicer.Service.Cliente;
using Reciicer.Service.Coleta;
using Reciicer.Service.TipoMaterial;


namespace Reciicer.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ClienteService _clienteService;
    private readonly ColetaService _coletaService;
    private readonly TipoMaterialService _tipoMaterialService;

    public HomeController(ILogger<HomeController> logger, ClienteService clienteService, ColetaService coletaService,
                          TipoMaterialService tipoMaterialService)
    {
        _logger = logger;
        _clienteService = clienteService;
        _coletaService  = coletaService;
        _tipoMaterialService  = tipoMaterialService;

    }


    public IActionResult Index(int? anoDashboard)
    {

        var model = new HomeIndexViewModel{
            TotalCliente = _clienteService.ObterTotalClientes(anoDashboard),
            TotalColeta = _coletaService.ObterTotalMaterialColeta(anoDashboard),
            DataUltimaColeta = _coletaService.ObterDataUltimaColeta().ToString("dd/MM/yyyy HH:mm"),
            TipoMaterialQuantidadeCharts =  _tipoMaterialService.ObterNomeQuantidadeTipoMaterialGrafico(anoDashboard),
            Top10Clientes = _clienteService.ObterClientesOrdenadoPorPontuação(),
            ClientePorMes = _clienteService.ObterTotalClientesPorMes(anoDashboard),
            ColetasPorMes = _coletaService.ObterTotalColetasPorMes(anoDashboard),
            AnoSelecionado = anoDashboard ?? DateTime.Now.Year
        };
     
        return View(model);
    }

    [AllowAnonymous]
    public IActionResult Privacy()
    {    
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
