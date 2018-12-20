using AutoMapper;

namespace LocadoraApp.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}
