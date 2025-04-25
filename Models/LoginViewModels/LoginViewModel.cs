using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.LoginViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage ="E-mail deve ser informado")]
        [EmailAddress(ErrorMessage ="Insira um E-mail válido")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage ="Informe uma senha válida")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Password { get; set; } =  string.Empty;

        [Display(Name = "Lembrar de min?")]
        public bool RememberMe { get; set; }
        }
}