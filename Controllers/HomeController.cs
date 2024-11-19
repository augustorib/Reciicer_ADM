using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models;
using Reciicer.Models.HomeViewModels;
using Reciicer.Service.Cliente;
using Reciicer.Service.Coleta;


namespace Reciicer.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ClienteService _clienteService;
    private readonly ColetaService _coletaService;

    public HomeController(ILogger<HomeController> logger, ClienteService clienteService, ColetaService coletaService)
    {
        _logger = logger;
        _clienteService = clienteService;
        _coletaService  = coletaService;

    }


    public IActionResult Index()
    {
        var model = new HomeIndexViewModel{
            TotalCliente = _clienteService.ObterTotalClientes(),
            TotalColeta = _coletaService.ObterTotalMaterialColeta(),
            // MateriaisNome = _materialService.ListarNomesMaterial(),
            DataUltimaColeta = _coletaService.ObterDataUltimaColeta()
            // chartMaterials =  _materialService.ObterMaterialQuantidadeChart(),
            // Clientes = _clienteService.ObterClientesOrdenadoPorPontuação(),
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
