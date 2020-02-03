using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperTest.Test.Helper
{
   public class DependencyResolverHelper
   {
       private static readonly IServiceCollection ServiceCollection
           = new ServiceCollection().AddAutoMapper(typeof(Startup));
              

        private static IServiceProvider _serviceProvider = null;

        public static T Resolve<T>()
        {
            if (_serviceProvider == null) _serviceProvider = ServiceCollection.BuildServiceProvider();

            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
