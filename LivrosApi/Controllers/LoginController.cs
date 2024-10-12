using AutoMapper;
using LivrosApi.Data;
using LivrosApi.Data.Dtos;
using LivrosApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Livros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private LivroContext _context;
        private IMapper _mapper;

        public LoginController(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RecuperarLogin(string Cpf)
        {

            var Login = _context.Logins.FirstOrDefault(l => l.Usuario.Cpf == Cpf);
            if (Login == null) return NotFound();
            var LoginDto = _mapper.Map<ReadLoginDto>(Login);
            return Ok(LoginDto);
        }
    }
}
