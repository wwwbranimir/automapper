using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTest.Destination;
using AutoMapperTest.Source;

namespace AutoMapperTest.Repositories
{
    internal class UrlItemRepository<TSource, TDestination> : IUrlItemRepository<TSource, TDestination>
    {
        private readonly IMapper _mapper;

        public UrlItemRepository( IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<TDestination> GetUrlItem(TSource source)
        {
            return  await Task.Run( ()=> _mapper.Map<TSource, TDestination>(source));
        }
    }
}