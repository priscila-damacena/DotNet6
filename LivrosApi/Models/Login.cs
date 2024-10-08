
using System.ComponentModel.DataAnnotations;
namespace LivrosApi.Models
{
    public class Login
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }

        [Required]
        public char TipoUsuario { get; set; }
    }
}
