using System;

namespace LocadoraApp.Application.ViewModel
{
    public class FilmeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiretorId { get; set; }
        public int GeneroId { get; set; }
        public string Sinopse { get; set; }
        public DateTime DataLancamento { get; set; }

        public GeneroNameViewModel Genero { get; set; }
        public DiretorNameViewModel Diretor { get; set; }
    }
}
