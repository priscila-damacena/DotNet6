using Livros.Api.Models;
using LivrosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrosApi.Data;

    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> opts)
            : base(opts) 
        {
                
        }
    public DbSet<Livro> Livros { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Login> Logins { get; set; }

    public DbSet<Publicacao> Publicacoes { get; set; }

    public DbSet<Comentario> Comentarios { get; set; }

}
