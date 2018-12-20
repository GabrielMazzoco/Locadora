using LocadoraApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocadoraApp.Data.Repository.Interfaces
{
    public interface IGeneroRepository : IBaseRepository<Genero>
    {
         IEnumerable<Genero> BuscarTodosGenerosComFilmes();
         Genero  BuscarGeneroComFilme(int id);
    }
}
