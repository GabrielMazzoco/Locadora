using LocadoraApp.Data.Repository.Interfaces;
using LocadoraApp.Data.Services.Interfaces;
using LocadoraApp.Entities;
using System.Collections.Generic;

namespace LocadoraApp.Data.Services
{
    public class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroService(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        public Genero BuscarGenero(int id)
        {
            return _generoRepository.BuscarGeneroComFilme(id);
        }

        public IEnumerable<Genero> BuscarTodos()
        {
            return _generoRepository.BuscarTodosGenerosComFilmes();
        }

        public Genero CadastrarGenero(Genero genero)
        {
            _generoRepository.Add(genero);
            _generoRepository.SaveChanges();
            return genero;
        }

        public void DeletarGenero(int id)
        {
            _generoRepository.Remove(id);
            _generoRepository.SaveChanges();
        }

        public Genero Editar(Genero genero)
        {
            _generoRepository.Update(genero);
            _generoRepository.SaveChanges();
            return genero;
        }
    }
}
