using AutoMapper;
using LivrosApi.Data;
using LivrosApi.Data.Dtos;
using LivrosApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace LivrosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LivroController : ControllerBase
{

    private LivroContext _context;
    private IMapper _mapper;

    public LivroController(LivroContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    /// <summary>
    /// Adiciona um Livro ao banco de dados
    /// </summary>
    /// <param name="LivroDto">Objeto com os campos necessários para criação de um Livro</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionarLivro([FromBody] CreateLivroDto LivroDto)
    {
        Livro Livro = _mapper.Map<Livro>(LivroDto);
        _context.Livros.Add(Livro);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuparaLivroPorId), new { id = Livro.Id }, Livro);
    }

    [HttpGet]
    public IEnumerable<ReadLivroDto> RecuperarLivros([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadLivroDto>>(_context.Livros.Skip(skip).Take(take));
    }
    [HttpGet("{id}")]
    public IActionResult RecuparaLivroPorId(int id)
    {
        var Livro = _context.Livros.FirstOrDefault(Livros => Livros.Id == id);
        if (Livro == null) return NotFound();
        var LivroDto = _mapper.Map<ReadLivroDto>(Livro);
        return Ok(LivroDto);

    }
    [HttpPut("{id}")]
    public IActionResult AtualizaLivro(int id, [FromBody] UpdateLivroDto LivroDto)
    {
        var Livro = _context.Livros.FirstOrDefault(Livro => Livro.Id == id);
        if (Livro == null) return NotFound();
        _mapper.Map(LivroDto, Livro);
        _context.SaveChanges();
        return NoContent();

    }

    [HttpPatch("{id}")]
    public IActionResult AtualizaLivroParcial(int id, JsonPatchDocument<UpdateLivroDto> pacth)
    {
        var Livro = _context.Livros.FirstOrDefault(Livro => Livro.Id == id);
        if (Livro == null) return NotFound();
        var LivroParaAtualizar = _mapper.Map<UpdateLivroDto>(Livro);
        pacth.ApplyTo(LivroParaAtualizar, ModelState);
        if (!TryValidateModel(LivroParaAtualizar))
            return ValidationProblem(ModelState);
        _mapper.Map(LivroParaAtualizar, Livro);
        _context.SaveChanges();
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult DeletaLivro(int id)
    { 
        var Livro = _context.Livros.FirstOrDefault(Livro => Livro.Id == id);
        if (Livro == null) return NotFound();
        _context.Remove(Livro);
        _context.SaveChanges();
        return NoContent();
  }
}

// controla as requisições do livro