using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;
namespace Livros.Api.Models
{
    public class Publicacao
    {
        public Publicacao(int usuario, int livro, string resenha)
        {
            UsuarioId = usuario;
            LivroId = livro;
            Resenha = resenha;
        }

        public Publicacao()
        {

        }

        [Key]
        [Required]
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int LivroId { get; set; }

        public List<Comentario> Comentario { get; set; }

        [Required(ErrorMessage = "A resenha do Livro é obrigatória")]
        public string Resenha { get; set; }

        public int Reacao { get; set; }
    }
}
