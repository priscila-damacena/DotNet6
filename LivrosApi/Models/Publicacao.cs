using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;
namespace Livros.Api.Models
{
    public class Publicacao
    {
        public Publicacao(Usuario usuario, Livro livro, string resenha)
        {
            Usuario = usuario;
            Livro = livro;
            Resenha = resenha;
        }

        public Publicacao()
        {

        }

        [Key]
        [Required]
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public Livro Livro { get; set; }

        public List<Comentario> Comentario { get; set; }

        [Required(ErrorMessage = "A resenha do Livro é obrigatória")]
        public string Resenha { get; set; }

        public int Reacao { get; set; }
    }
}
