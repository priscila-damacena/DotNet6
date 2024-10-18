using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.UsuarioDto
{
    public class CreateUsuarioDto
    {

        [Required(ErrorMessage = " O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = " A CPF é obrigatório")]
        [MaxLength(11, ErrorMessage = "O CPF não pode exceder 11 caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = " A Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = " A Data de Nascimento é obrigatória")]
        public DateOnly DataDeNascimento { get; set; }
    }
}
