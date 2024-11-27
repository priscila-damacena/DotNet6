using AutoMapper;
using Livros.Api.Data.Dtos.LivroDto;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.UsuarioDto;
using Livros.Api.Models;
using LivrosApi.Data;
using LivrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livros.Api.Service
{
    public class LivroService
    {
        private LivroContext _context;
        private IMapper _mapper;

        public LivroService(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Livro RecuperarlivroPorId(int id)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.Id == id);
            if (livro == null) return new Livro();
            return livro;
        }

        public List<Livro> RecuperarLivros()
        {
            return _context.Livros.ToList();

        }

        public Livro AdicionarLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            return livro;
        }

    }
}

