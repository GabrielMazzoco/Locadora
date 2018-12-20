using System;
using System.Collections.Generic;

namespace LocadoraApp.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Filme> Filmes { get; set; }
    }
}
