using LocadoraApp.Entities;
using System.Collections.Generic;

namespace LocadoraApp.Data.Repository.Interfaces
{
    public interface IFilmeRepository : IBaseRepository<Filme>
    {
        IEnumerable<Filme> BuscarTodosFilmes();
        Filme BuscarFilme(int id);
    }
}
