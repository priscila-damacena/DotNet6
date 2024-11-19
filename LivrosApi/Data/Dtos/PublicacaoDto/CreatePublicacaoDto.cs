using Livros.Api.Data.Dtos.UsuarioDto;
using Livros.Api.Models;
using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.PublicacaoDto
{
    public class CreatePublicacaoDto
    {

        public int IdUsuario { get; set; }

        public int IdLivro { get; set; }


        [Required(ErrorMessage = "A resenha do Livro é obrigatória")]
        public string Resenha { get; set; }
    }
}
