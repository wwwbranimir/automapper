using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTest.Destination;
using AutoMapperTest.Source;
using Xunit;
using AutoMapperTest.Test.Helper;
using Moq;
using Xunit.Sdk;

namespace AutoMapperTest.Test
{
    public class AutoMapperShould
    {
        [Fact]
        public async Task ConcatenateNameAndSurNameFromUrlItemToUrlItemDto()
        {
            await Task.Run(() =>
            {
                var mapper = DependencyResolverHelper.Resolve<IMapper>();
                var test = mapper.Map<UrlItem, UrlItemDto>(UrlItem.Default);

            });

        }
        [Fact]
        public async Task Test1()
        {
        }
        [Fact]
        public async Task Test2()
        {
        }

    }
}
