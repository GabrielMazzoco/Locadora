using LocadoraApp.Data.Context;
using LocadoraApp.Data.Repository.Interfaces;
using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraApp.Data.Repository
{
    public class GeneroRepository : BaseRepository<Genero>, IGeneroRepository
    {
        public GeneroRepository(LocadoraAppContext context) : base(context)
        {
        }

        public Genero BuscarGeneroComFilme(int id)
        {
            var genero = DbSet.Include(g => g.Filmes).FirstOrDefault(g => g.Id == id);
            return genero;
        }

        public IEnumerable<Genero> BuscarTodosGenerosComFilmes()
        {
            var generos = this.DbSet.Include(g => g.Filmes);
            return generos;
        }
    }
}
