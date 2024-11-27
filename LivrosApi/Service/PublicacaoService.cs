using AutoMapper;
using Livros.Api.Models;
using LivrosApi.Data;
using LivrosApi.Models;

namespace Livros.Api.Service
{
    public class PublicacaoService
    {

        private LivroContext _context;
        private IMapper _mapper;

        public PublicacaoService(LivroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Publicacao RecuperarPublicacaoPorId(int id)
        {
            var publicacao = _context.Publicacoes.FirstOrDefault(l => l.Id == id);
            if (publicacao == null) return new Publicacao();
            return publicacao;
        }
        public List<Publicacao> RecuperarPublicacoes()
        {
            return _context.Publicacoes.ToList();

        }

        public Publicacao AdicionarPublicacao(Publicacao publicacao)
        {
            _context.Publicacoes.Add(publicacao);
            return publicacao;
        }
    }
}
