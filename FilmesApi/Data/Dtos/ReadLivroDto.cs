using System.ComponentModel.DataAnnotations;

namespace LivrosApi.Data.Dtos
{
    public class ReadLivroDto
    {
        
        public string Titulo { get; set; }
        
        public string Genero { get; set; }
        
        public int Duracao { get; set; }
        
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

    }
}
