using AutoMapper;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.PublicacaoDto;
using Livros.Api.Models;
using Livros.Api.Service;
using LivrosApi.Data;
using LivrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livros.Api.Controllers
{
    public class PublicacaoController : Controller
    {
        private LivroContext _context;
        private IMapper _mapper;
        private PublicacaoService _publicacaoService;

        public PublicacaoController(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _publicacaoService = new PublicacaoService(context, mapper);
        }
        [HttpPost]
        public IActionResult AdicionarPublicacao([FromBody] CreatePublicacaoDto publicacaoDto)
        {
            Publicacao publicacao = new Publicacao();
            try
            {
                Usuario usuario = _mapper.Map<Usuario>(publicacaoDto.IdUsuario);
                Livro livro = _mapper.Map<Livro>(publicacaoDto.IdLivro);
                Publicacao varPublicacao = new Publicacao(usuario, livro, publicacaoDto.Resenha);
                publicacao = _publicacaoService.AdicionarPublicacao(varPublicacao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(publicacao);
        }
    }
}
