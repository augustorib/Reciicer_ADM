using System.ComponentModel;
using Microsoft.AspNetCore.Identity;
using Reciicer.Models.Entities;

namespace Reciicer.Models.RoleViewModels
{
    public class UserRoleViewModel
    {
        public string? Id { get; set; }

        [DisplayName("Nome do Usuário: ")]
        public string? UserName { get; set; }
        [DisplayName("E-mail:")]
        public string? Email { get; set; }
        [DisplayName("Ponto de Coleta: ")]
        public string? PontoColeta { get; set; }
        public List<string>? Roles { get; set; }
        [DisplayName("Função:")]
        public string? Role { get; set; }
        public IEnumerable<IdentityRole>? RolesList { get; set; }
        public IEnumerable<PontoColeta>? PontoColetas { get; set; }

        public int PontoColetaId { get; set; }  
        public string? RoleId { get; set; }  
    }
}