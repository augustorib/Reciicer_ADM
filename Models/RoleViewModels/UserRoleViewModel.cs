
namespace Reciicer.Models.RoleViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PontoColeta { get; set; }
        public List<string> Roles { get; set; }
    }
}