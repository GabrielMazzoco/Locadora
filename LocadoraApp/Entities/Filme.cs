using System;

namespace LocadoraApp.Entities
{
    public class Filme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiretorId { get; set; }
        public int GeneroId { get; set; }
        public string Sinopse { get; set; }
        public  DateTime DataLancamento { get; set; }

        public Genero Genero { get; set; }
        public Diretor Diretor { get; set; }


    }
}
