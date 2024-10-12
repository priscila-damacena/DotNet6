using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;

namespace LivrosApi.Data.Dtos
{
    public class ReadLoginDto
    {
        
        public int Id { get; set; }
        public string Senha { get; set; }
        public char TipoUsuario { get; set; }
    }
}
