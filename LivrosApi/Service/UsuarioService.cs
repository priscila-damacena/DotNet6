using AutoMapper;
using Livros.Api.Data.Dtos.LivroDto;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.UsuarioDto;
using LivrosApi.Data;
using LivrosApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livros.Api.Service
{
    public class UsuarioService 
    {
        private LivroContext _context;
        private IMapper _mapper;

        public UsuarioService(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Usuario RecuperarUsuarioPorId(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(l => l.Id == id);
            if (usuario == null) return new Usuario();
            return usuario;
        }

        public Usuario AdicionarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            return usuario;
        }

    }
}

