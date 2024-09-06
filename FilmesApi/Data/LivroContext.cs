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
    
}
