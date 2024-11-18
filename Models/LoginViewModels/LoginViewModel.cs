using System.ComponentModel.DataAnnotations;


namespace Reciicer.Models.LoginViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage ="E-mail deve ser informado")]
        [EmailAddress(ErrorMessage ="Insira um e-mail válido")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe uma senha válida")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]
        public string Password { get; set; }

        [Display(Name = "Lembrar de min?")]
        public bool RememberMe { get; set; }
        }
}