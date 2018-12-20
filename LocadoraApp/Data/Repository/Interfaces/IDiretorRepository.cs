using LocadoraApp.Entities;
using System.Collections.Generic;

namespace LocadoraApp.Data.Repository.Interfaces
{
    public interface IDiretorRepository : IBaseRepository<Diretor>
    {
        IEnumerable<Diretor> BuscarTodosDIretoresComFilmes();
        Diretor BuscarDiretorComFilme(int id);
    }
}
