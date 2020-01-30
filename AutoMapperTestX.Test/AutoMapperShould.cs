using System;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTest.Destination;
using AutoMapperTest.Source;
using AutoMapperTestX.Test.Helper;
using AutoMapperTestX.Test.Model;
using FluentAssertions;
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
                DependencyResolverHelper.DependencyResolverHelperX();
                var mapper = DependencyResolverHelper.Resolve<IMapper>();

                //var fakeRepository = new MockRepository();
                var actual = mapper.Map<UrlItem, UrlItemDto>(UrlItem.Default);
                var expected = TestModel.GetExpected();
                actual.Should().BeEquivalentTo(expected);
                //string actual = "ABCDEFGHI";
                //actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
            });

        }
        [Fact]
        public void Test1()
        {

        }
    }
}
