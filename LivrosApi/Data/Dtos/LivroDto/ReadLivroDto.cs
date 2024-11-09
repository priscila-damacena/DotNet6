using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.LivroDto
{
    public class ReadLivroDto
    {

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public int qtdePagina { get; set; }

        public string Autor { get; set; }

        public string Imagem { get; set; }

        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

    }
}
