
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.LoginViewModels
{
    public class RegisterViewModel
    {
    
        [Required(ErrorMessage ="Nome de usuário deve ser informado")]
        [Display(Name = "Usuário:")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Nome deve ser informado")]
        [EmailAddress]
        [Display(Name = "E-mail:")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha deve ser informado")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirmação de senha deve ser informado")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha:")]
        [Compare("Password", ErrorMessage = "As senhas devem ser iguais")]
        public string? ConfirmPassword { get; set; }
    }
}