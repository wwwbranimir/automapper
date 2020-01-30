using AutoMapper;
using AutoMapperTest.Destination;
using AutoMapperTest.Source;

namespace AutoMapperTest.Profiles
{
    internal class UrlItemProfile : Profile
    {
        public UrlItemProfile()
        {
            CreateMap<UrlItem, UrlItemDto>().ForMember(dest => dest.FullName,
                opt => opt.MapFrom(src => $"{src.Name} {src.SurName} Car"));
        }
    }
}
