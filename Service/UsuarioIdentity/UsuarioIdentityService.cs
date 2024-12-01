using Microsoft.AspNetCore.Identity;
using Entities = Reciicer.Models.Entities;

namespace Reciicer.Service.UsuarioIdentity
{
    public class UsuarioIdentityService
    {
        private readonly UserManager<Entities.UsuarioIdentity> _userManager;

        public UsuarioIdentityService(UserManager<Entities.UsuarioIdentity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Entities.UsuarioIdentity> ObterUsuarioIdentityPorIdAsync(string usuarioGuid)
        {
            return await _userManager.FindByIdAsync(usuarioGuid);
        }
  
        
    }
}