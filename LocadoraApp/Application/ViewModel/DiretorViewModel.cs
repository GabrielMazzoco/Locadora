using System.Collections.Generic;

namespace LocadoraApp.Application.ViewModel
{
    public class DiretorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }

        public ICollection<FilmeNameViewModel> Filmes { get; set; }
    }
}
