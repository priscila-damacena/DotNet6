using AutoMapper;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.UsuarioDto;
using LivrosApi.Models;

namespace LivrosApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<ReadUsuarioDto, Usuario>();
            CreateMap<Usuario, CreateUsuarioDto>();
        }
    }
}
