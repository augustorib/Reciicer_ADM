using Reciicer.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Reciicer.Models.RoleViewModels;
using Reciicer.Service.PontoColeta;

namespace Reciicer.Controllers
{

    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly UserManager<UsuarioIdentity> _userManager;

        private readonly PontoColetaService _pontoColetaService;
        

        public RoleController(UserManager<UsuarioIdentity> userManager, PontoColetaService pontoColetaService)
        {
            _userManager = userManager;
            _pontoColetaService = pontoColetaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();
            var model = new UserRoleListViewModel
            {
                Users = new List<UserRoleViewModel>()
            };

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);

                
                model.Users.Add(new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.NormalizedUserName,
                    PontoColeta = _pontoColetaService.ObterPontoColetaPorId(user.PontoColetaId).Nome,
                    Email = user.Email,
                    Roles = roles.ToList()
                });
            }
            
            
            return View(model);
        }

    }
}