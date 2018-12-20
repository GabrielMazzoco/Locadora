using System.Collections.Generic;

namespace LocadoraApp.Application.ViewModel
{
    public class GeneroViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<FilmeNameViewModel> Filmes { get; set; }
    }
}
