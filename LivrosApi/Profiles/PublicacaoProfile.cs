using AutoMapper;
using Livros.Api.Data.Dtos.LoginDto;
using Livros.Api.Data.Dtos.PublicacaoDto;
using Livros.Api.Data.Dtos.UsuarioDto;
using Livros.Api.Models;
using LivrosApi.Models;

namespace LivrosApi.Profiles
{
    public class PublicacaoProfile : Profile
    {
        public PublicacaoProfile()
        {
            CreateMap<Publicacao, CreatePublicacaoDto>();
            CreateMap<CreatePublicacaoDto, Publicacao>();
        }
    }
}
