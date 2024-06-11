using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models;
using Reciicer.Models.HomeViewModels;
using Reciicer.Service.Cliente;
using Reciicer.Service.Material;
using Reciicer.Service.Reciclagem;

namespace Reciicer.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ClienteService _clienteService;
    private readonly ReciclagemService _reciclagemService;
    private readonly MaterialService _materialService;

    public HomeController(ILogger<HomeController> logger, ClienteService clienteService, ReciclagemService reciclagemService
                          ,MaterialService materialService  )
    {
        _logger = logger;
        _clienteService = clienteService;
        _reciclagemService = reciclagemService;
        _materialService = materialService;
    }


    public IActionResult Index()
    {
        var model = new HomeIndexViewModel{
            TotalCliente = _clienteService.ObterTotalClientes(),
            TotalReciclagem = _reciclagemService.ObterTotalMaterialReciclagem(),
            MateriaisNome = _materialService.ListarNomesMaterial(),
            DataUltimaReciclagem = _reciclagemService.ObterDataUltimaReciclagem(),
            chartMaterials =  _materialService.ObterMaterialQuantidadeChart(),
            Clientes = _clienteService.ObterClientesOrdenadoPorPontuação(),
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
