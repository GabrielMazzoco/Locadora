using System.Collections.Generic;
using System.Linq;
using LocadoraApp.Data.Context;
using LocadoraApp.Data.Repository.Interfaces;
using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocadoraApp.Data.Repository
{
    public class DiretorRepository : BaseRepository<Diretor>, IDiretorRepository
    {
        public DiretorRepository(LocadoraAppContext context) : base(context)
        {
        }

        public Diretor BuscarDiretorComFilme(int id)
        {
            var diretor = DbSet.Include(d => d.Filmes).FirstOrDefault(g => g.Id == id);
            return diretor;
        }

        public IEnumerable<Diretor> BuscarTodosDIretoresComFilmes()
        {
            var diretores = DbSet.Include(d => d.Filmes);
            return diretores;
        }
    }
}
