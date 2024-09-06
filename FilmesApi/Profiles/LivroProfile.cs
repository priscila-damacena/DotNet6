using AutoMapper;
using LivrosApi.Data.Dtos;
using LivrosApi.Models;

namespace LivrosApi.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<CreateLivroDto, Livro>();
            CreateMap<UpdateLivroDto, Livro>();
            CreateMap<Livro, UpdateLivroDto>();
            CreateMap<Livro, ReadLivroDto>();
        }
    }
}
