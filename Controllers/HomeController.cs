using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models;
using Reciicer.Models.HomeViewModels;
using Reciicer.Service.Cliente;


namespace Reciicer.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ClienteService _clienteService;

    public HomeController(ILogger<HomeController> logger, ClienteService clienteService )
    {
        _logger = logger;
        _clienteService = clienteService;

    }


    public IActionResult Index()
    {
     
        return View();
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
