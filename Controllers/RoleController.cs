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
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly PontoColetaService _pontoColetaService;
        

        public RoleController(UserManager<UsuarioIdentity> userManager, PontoColetaService pontoColetaService, RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _pontoColetaService = pontoColetaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList().Where(u => u.PontoColetaId == Convert.ToInt32(User.FindFirst("PontoColetaId")?.Value)).ToList();
            var model = new UserRoleListViewModel
            {
                Users = new List<UserRoleViewModel>()
            };

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);

                
                model.Users.Add(new UserRoleViewModel
                {
                    Id = user.Id,
                    UserName = user.NormalizedUserName!,
                    PontoColeta = _pontoColetaService.ObterPontoColetaPorId(user.PontoColetaId).Nome,
                    Email = user.Email,
                    Roles = roles.ToList()
                });
            }
            
            
            return View(model);
        }

        [HttpGet]
        public IActionResult Read(string id)
        { 
            var user = _userManager.Users.FirstOrDefault(u => u.Id == id);
            
            var model = new UserRoleViewModel
            {
                Id = user!.Id,
                UserName = user.NormalizedUserName!,
                PontoColeta = _pontoColetaService.ObterPontoColetaPorId(user.PontoColetaId).Nome ?? string.Empty,
                Email = user!.Email ?? string.Empty,
                Role = _userManager.GetRolesAsync(user).Result.FirstOrDefault() ?? string.Empty,
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Update(string id)
        { 
            var user = _userManager.Users.FirstOrDefault(u => u.Id == id);
            
            var model = new UserRoleViewModel
            {
                Id = user!.Id,
                UserName = user.UserName!,
                PontoColeta = _pontoColetaService.ObterPontoColetaPorId(user.PontoColetaId).Nome ?? string.Empty,
                Email = user!.Email ?? string.Empty,
                Role = _userManager.GetRolesAsync(user).Result.FirstOrDefault() ?? string.Empty,
                RolesList = _roleManager.Roles.ToList(),
                PontoColetas = _pontoColetaService.ListarPontoColeta(),
            };


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UserRoleViewModel userRoleViewModel)
        { 
            //TODO: Se for alterar o ponto de Coleta deve ser feito o ajuste na Claim
            var usuarioAtualizar =  _userManager.FindByIdAsync(userRoleViewModel.Id!).Result;

            usuarioAtualizar!.UserName = userRoleViewModel.UserName;
            usuarioAtualizar.Email = userRoleViewModel.Email;
            usuarioAtualizar.PontoColetaId = userRoleViewModel.PontoColetaId;
            
            await _userManager.UpdateAsync(usuarioAtualizar);
            await _userManager.RemoveFromRolesAsync(usuarioAtualizar, _userManager.GetRolesAsync(usuarioAtualizar).Result);
            await _userManager.AddToRoleAsync(usuarioAtualizar,  _roleManager.FindByIdAsync(userRoleViewModel.RoleId).Result.NormalizedName);


            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        { 
            
            var usuarioDeletar = await _userManager.FindByIdAsync(id);

            await _userManager.DeleteAsync(usuarioDeletar);

            return RedirectToAction("Index");
        }
    }
}