using AutoMapper;
using Livros.Api.Data.Dtos.LivroDto;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.UsuarioDto;
using Livros.Api.Service;
using LivrosApi.Data;
using LivrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private LivroContext _context;
        private IMapper _mapper;
        private UsuarioService _usuarioService;

        public LoginController(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _usuarioService = new UsuarioService(context, mapper);
        }

        [HttpGet]
        public IActionResult RecuperarLogin(string Cpf)
        {

            var Login = _context.Logins.FirstOrDefault(l => l.Usuario.Cpf == Cpf);
            if (Login == null) return NotFound();
            var LoginDto = _mapper.Map<ReadLoginDto>(Login);
            return Ok(LoginDto);
        }

        [HttpGet]
        [Route("RecuperarTodosLogins")]
        public IActionResult RecuperarTodosLogins()
        {

            var Login = _context.Logins.ToList();
            if (Login == null) return NotFound();
            var LoginDto = _mapper.Map<List<ReadLoginDto>>(Login);
            return Ok(LoginDto);
        }


        [HttpPost]
         public IActionResult AdicionarLoginUsuario([FromBody] CreateLoginDto LoginDto)
        {
            Login login = new Login();
            try
            {
                Usuario usuario = _mapper.Map<Usuario>(LoginDto.usuario);
                Usuario user = _usuarioService.AdicionarUsuario(usuario);


                login = _mapper.Map<Login>(LoginDto);
                login.Usuario = usuario;
                _context.Logins.Add(login);
                _context.SaveChanges();
            }
            catch ( Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
            return Ok(login);
        }

    }
}

