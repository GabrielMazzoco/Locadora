using AutoMapper;
using LocadoraApp.Application.ViewModel;
using LocadoraApp.Entities;

namespace LocadoraApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Filme, FilmeViewModel>();
            CreateMap<Diretor, DiretorViewModel>();
            CreateMap<Genero, GeneroViewModel>();
            CreateMap<Filme, FilmeNameViewModel>();
            CreateMap<Diretor, DiretorNameViewModel>();
            CreateMap<Genero, GeneroNameViewModel>();
        }
    }
}
