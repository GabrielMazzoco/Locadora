using LocadoraApp.Data.Repository.Interfaces;
using LocadoraApp.Data.Services.Interfaces;
using LocadoraApp.Entities;
using System.Collections.Generic;

namespace LocadoraApp.Data.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public Filme BuscarFilme(int id)
        {
            return _filmeRepository.BuscarFilme(id);
        }

        public IEnumerable<Filme> BuscarTodos()
        {
            return _filmeRepository.BuscarTodosFilmes();
        }

        public Filme CadastrarFilme(Filme filme)
        {
            _filmeRepository.Add(filme);
            _filmeRepository.SaveChanges();
            return filme;
        }

        public void DeletarFilme(int id)
        {
            _filmeRepository.Remove(id);
            _filmeRepository.SaveChanges();
        }

        public Filme Editar(Filme filme)
        {
            _filmeRepository.Update(filme);
            _filmeRepository.SaveChanges();
            return filme;
        }
    }
}
