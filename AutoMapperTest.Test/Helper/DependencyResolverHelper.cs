using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperTest.Test.Helper
{
   internal class DependencyResolverHelper
   {
       private static readonly IServiceCollection ServiceCollection
           = new ServiceCollection(); //TODO: @srdjan.blagojevic here you will register dependency via builder pathern
              

        private static IServiceProvider _serviceProvider = null;

        public static T Resolve<T>()
        {
            if (_serviceProvider == null) _serviceProvider = ServiceCollection.BuildServiceProvider();

            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
