using System;
using System.Collections;
using System.Collections.Generic;

namespace LocadoraApp.Entities
{
    public class Diretor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }

        public ICollection<Filme> Filmes { get; set; }
    }
}
