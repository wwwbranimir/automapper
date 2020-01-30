using System;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTest.Destination;
using AutoMapperTest.Source;
using AutoMapperTestX.Test.Helper;
using Xunit;

namespace AutoMapperTestX.Test
{
    public class AutoMapperShould
    {
        [Fact]
        public async Task ConcatenateNameAndSurNameFromUrlItemToUrlItemDto()
        {
            await Task.Run(() =>
            {
                var mapper = DependencyResolverHelper.Resolve<IMapper>();

                //var fakeRepository = new MockRepository();
                var test = mapper.Map<UrlItem, UrlItemDto>(UrlItem.Default);
            });

        }
        [Fact]
        public void Test1()
        {

        }
    }
}
