using System.ComponentModel.DataAnnotations;

namespace Capitulo01.Models.Infra
{
    public class RegistrarNovoUsuarioViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="A {0} precisa ter ao menos {2} e no máximo {1} caracteres de cumprimento.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "Os valores informado para SENHA e COFIRMAÇÃO não são iguais.")]
        public string ConfirmPassword { get; set; }
    }
}
