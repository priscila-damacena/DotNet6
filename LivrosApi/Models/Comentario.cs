using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;
namespace Livros.Api.Models
{
    public class Comentario
    {
        [Key]
        [Required]

        public int id { get; set; }

        public Usuario Usuario { get; set; }


        public string Descricao { get; set; }
    }
}
