using AutoMapper;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.UsuarioDto;
using LivrosApi.Models;

namespace LivrosApi.Profiles
{
    public class LoginProfile : Profile
    {
        public LoginProfile()
        {
            CreateMap<ReadLoginDto, Login>();
            CreateMap<Login, ReadLoginDto>();
            CreateMap<Login, CreateLoginDto>();
            CreateMap<CreateLoginDto, Login>();
        }
    }
}
