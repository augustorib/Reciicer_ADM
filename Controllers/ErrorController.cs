using Microsoft.AspNetCore.Diagnostics;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models;
using Reciicer.Service.Error;

namespace Reciicer.Controllers
{
    
    public class ErrorController : Controller
    {

        private readonly ErrorHandlingService _errorHandlingService;

        public ErrorController(ErrorHandlingService errorHandlingService)
        {
            _errorHandlingService = errorHandlingService;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            var errorData = HttpContext.Features.Get<IExceptionHandlerFeature>();
            
            var model = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                ErrorMessage = _errorHandlingService.ErrorMessage(errorData!.Error),
                StatusCode = _errorHandlingService.ErrorStatusCode(errorData.Error)
            };

            return View(model);
        }
    }
}