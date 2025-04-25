using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Reciicer.Models.Entities;
using Reciicer.Models.LoginViewModels;
using Reciicer.Service.PontoColeta;
using System.Security.Claims;


namespace Reciicer.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<UsuarioIdentity> _userManager;
        private readonly SignInManager<UsuarioIdentity> _signInManager;
        private readonly PontoColetaService _pontoColetaService;
    
        public LoginController(SignInManager<UsuarioIdentity> signInManager, UserManager<UsuarioIdentity> userManager, PontoColetaService pontoColetaService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _pontoColetaService = pontoColetaService;
            
        }


        [HttpGet]
        public IActionResult Login()
        {
            //Caso o usuário tenha um coockie ativo, redireciona para a página inicial. Isso evita a pagina 
            //de login ser exibida dentro do layout dos menus
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (ModelState.IsValid && user is not null)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName!, model.Password,  model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

            }
                    
            TempData["Mensagem"] = "Usuário ou senha inválidos!";
            
 
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UsuarioIdentity { UserName = model.UserName, Email = model.Email, PontoColetaId = 1 };
                
                var result = await _userManager.CreateAsync(user, model.Password!);

                var pontoColeta = _pontoColetaService.ObterPontoColetaPorId(user.PontoColetaId);

                if (result.Succeeded)
                {
                    await  _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Operador"));
                    await  _userManager.AddClaimAsync(user, new Claim("PontoColetaId", pontoColeta.Id.ToString()));
                    await  _userManager.AddToRoleAsync(user, "Operador");      

                    return RedirectToAction("Login", "Login");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }


    }
}