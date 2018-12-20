using System.Collections.Generic;
using System.Linq;
using LocadoraApp.Data.Context;
using LocadoraApp.Data.Repository.Interfaces;
using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApp.Data.Repository
{
    public class FilmeRepository : BaseRepository<Filme>, IFilmeRepository
    {
        public FilmeRepository(LocadoraAppContext context) : base(context)
        {
        }

        public Filme BuscarFilme(int id)
        {
            var filme = DbSet
                .Include(f => f.Diretor)
                .Include(f => f.Genero)
                .FirstOrDefault(f => f.Id == id);
            return filme;
        }

        public IEnumerable<Filme> BuscarTodosFilmes()
        {
            var filmes = DbSet
                .Include(f => f.Diretor)
                .Include(f => f.Genero);
            return filmes;
        }
    }
}
