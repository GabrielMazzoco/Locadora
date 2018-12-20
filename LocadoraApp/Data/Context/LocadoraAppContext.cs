using LocadoraApp.Data.Mappings;
using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApp.Data.Context
{
    public class LocadoraAppContext : DbContext
    {
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }

        public LocadoraAppContext(DbContextOptions<LocadoraAppContext> op) : base(op)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DiretorMap());
            modelBuilder.ApplyConfiguration(new FilmeMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());

            base.OnModelCreating(modelBuilder); 
        }
    }
}
