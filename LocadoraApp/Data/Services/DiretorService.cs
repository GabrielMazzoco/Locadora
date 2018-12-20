using System.Collections.Generic;
using LocadoraApp.Data.Repository.Interfaces;
using LocadoraApp.Data.Services.Interfaces;
using LocadoraApp.Entities;

namespace LocadoraApp.Data.Services
{
    public class DiretorService : IDiretorService
    {
        private readonly IDiretorRepository _diretorRepository;

        public DiretorService(IDiretorRepository diretorRepository)
        {
            _diretorRepository = diretorRepository;
        }

        public Diretor BuscarDiretor(int id)
        {
            return _diretorRepository.BuscarDiretorComFilme(id);
        }

        public IEnumerable<Diretor> BuscarTodos()
        {
            return _diretorRepository.BuscarTodosDIretoresComFilmes();
        }

        public Diretor CadastrarDiretor(Diretor diretor)
        {
            _diretorRepository.Add(diretor);
            _diretorRepository.SaveChanges();
            return diretor;
        }

        public void DeletarDiretor(int id)
        {
            _diretorRepository.Remove(id);
            _diretorRepository.SaveChanges();
        }

        public Diretor Editar(Diretor diretor)
        {
            _diretorRepository.Update(diretor);
            _diretorRepository.SaveChanges();
            return diretor;
        }
    }
}
