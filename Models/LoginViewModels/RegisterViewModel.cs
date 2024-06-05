
using System.ComponentModel.DataAnnotations;

namespace Reciicer.Models.LoginViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail:")]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha:")]
        [Compare("Password", ErrorMessage = "As senhas devem ser iguais")]
        public string? ConfirmPassword { get; set; }
    }
}