using Livros.Api.Models;
using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.LoginDto
{
    public class ReadPublicacaoDto
    {

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Livro Livro { get; set; }

        public Comentario comentario { get; set; }

        public string Resenha { get; set; }

        public int Reacao { get; set; }
    }
}
