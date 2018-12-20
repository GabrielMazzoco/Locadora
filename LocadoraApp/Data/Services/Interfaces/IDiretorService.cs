using LocadoraApp.Entities;
using System.Collections.Generic;

namespace LocadoraApp.Data.Services.Interfaces
{
    public interface IDiretorService
    {
        IEnumerable<Diretor> BuscarTodos();

        Diretor CadastrarDiretor(Diretor diretor);

        Diretor BuscarDiretor(int id);

        void DeletarDiretor(int id);

        Diretor Editar(Diretor diretor);
    }
}
