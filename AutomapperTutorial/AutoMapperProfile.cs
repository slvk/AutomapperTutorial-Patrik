using AutoMapper;

namespace AutomapperTutorial
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<SuperHero, SuperHeroDto>();
            //CreateMap<SuperHeroDto, SuperHero>();
            CreateMap<SuperHero, SuperHeroDto>().ReverseMap();
        }
    }
}
