using System.Threading.Tasks;

namespace AutoMapperTest.Repositories
{
    public interface IUrlItemRepository <TSource, TDestination>
    {
        Task<TDestination> GetUrlItem(TSource source);
    }
}
