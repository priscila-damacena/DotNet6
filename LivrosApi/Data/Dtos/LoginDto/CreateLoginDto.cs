using Livros.Api.Data.Dtos.UsuarioDto;
using LivrosApi.Models;
using System.ComponentModel.DataAnnotations;

namespace Livros.Api.Data.Dtos.LoginDto
{
    public class CreateLoginDto
    {
       
        public string Senha { get; set; }
        public char TipoUsuario { get; set; }
        public ReadUsuarioDto usuario { get; set; }


    }
}
