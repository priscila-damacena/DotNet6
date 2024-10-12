using AutoMapper;
using LivrosApi.Data.Dtos;
using LivrosApi.Models;

namespace LivrosApi.Profiles
{
    public class LoginProfile : Profile
    {
        public LoginProfile()
        {
            CreateMap<Login, ReadLoginDto>();
            CreateMap<Usuario, ReadLoginDto>();
        }
    }
}
