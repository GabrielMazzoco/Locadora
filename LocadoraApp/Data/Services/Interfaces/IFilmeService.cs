using LocadoraApp.Entities;
using System.Collections.Generic;

namespace LocadoraApp.Data.Services.Interfaces
{
    public interface IFilmeService
    {
        IEnumerable<Filme> BuscarTodos();

        Filme CadastrarFilme(Filme filme);

        Filme BuscarFilme(int id);

        void DeletarFilme(int id);

        Filme Editar(Filme filme);
    }
}
