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
    [ApiController]
    [Route("[controller]")]
    public class PublicacaoController : Controller
    {
        private LivroContext _context;
        private IMapper _mapper;
        private PublicacaoService _publicacaoService;
        private UsuarioService _usuarioService;
        private LivroService _livroService;

        public PublicacaoController(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _livroService = new LivroService(context, mapper);
            _publicacaoService = new PublicacaoService(context, mapper);
            _usuarioService = new UsuarioService(context, mapper);
        }
        [HttpPost]
        public IActionResult AdicionarPublicacao([FromBody] CreatePublicacaoDto publicacaoDto)
        {
            Publicacao publicacao = new Publicacao();
            try
            {
                Usuario usuario = _usuarioService.RecuperarUsuarioPorId(publicacaoDto.IdUsuario);
                if (usuario.Cpf is null)
                {
                    return BadRequest("usuario não encontrado");

                }
                Livro livro = _livroService.RecuperarlivroPorId(publicacaoDto.IdLivro);
                if (livro.Titulo is null)
                {
                    return BadRequest("livro não encontrado");

                }
                Publicacao varPublicacao = new Publicacao(publicacaoDto.IdUsuario, publicacaoDto.IdLivro, publicacaoDto.Resenha);
                publicacao = _publicacaoService.AdicionarPublicacao(varPublicacao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(publicacao);
        }

        [HttpGet]
        public IActionResult RecuperarPublicacoes()
        {
            var  publicacao = _publicacaoService.RecuperarPublicacoes();
            List<ReadPublicacaoDto> readPublicacaoDto = new List<ReadPublicacaoDto>();
            if (publicacao == null) return NotFound();
            publicacao.ForEach(x =>
            {
                var usuario = _usuarioService.RecuperarUsuarioPorId(x.UsuarioId);
                var livro = _livroService.RecuperarlivroPorId(x.LivroId);
                readPublicacaoDto.Add(new ReadPublicacaoDto()
                {
                    Id = x.Id,
                    Usuario = usuario,
                    Livro = livro,
                    comentario = new Comentario(),
                    Reacao = x.Reacao,
                    Resenha = x.Resenha
                });

            });

            return Ok(readPublicacaoDto);
        }
    }
}
