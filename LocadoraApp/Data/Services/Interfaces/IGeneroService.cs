using LocadoraApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocadoraApp.Data.Services.Interfaces
{
    public interface IGeneroService
    {
        IEnumerable<Genero> BuscarTodos();

        Genero CadastrarGenero(Genero genero);

        Genero BuscarGenero(int id);

        void DeletarGenero(int id);

        Genero Editar(Genero genero);
    }
}
