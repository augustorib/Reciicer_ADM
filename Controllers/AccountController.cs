using Microsoft.AspNetCore.Mvc;

namespace Reciicer.Controllers
{
    public class AccountController : Controller
    {
      
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}