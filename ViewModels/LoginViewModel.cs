using System.ComponentModel.DataAnnotations;

namespace DemoLogin.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; } = string.Empty;
    }
}
