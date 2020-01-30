using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AutoMapperTest;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using ILoggerFactory = Microsoft.Extensions.Logging.ILoggerFactory;
namespace AutoMapperTestX.Test.Helper
{
    public class DependencyResolverHelper
    {
        private static readonly IServiceCollection ServiceCollection
            = new ServiceCollection(); //TODO: @srdjan.blagojevic here you will register dependency via builder pathern


        public static IWebHost WebHostProp { get; private set; }
        
        private static IServiceProvider _serviceProvider = null;

        public IServiceScope _scope { get; private set; }

        public IMapper _mapper { get; private set; }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options =>
                {
                    options.AddServerHeader = false;
                })
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

        public static void DependencyResolverHelperX()
        {
            WebHostProp = BuildWebHost(null);
            _serviceProvider = WebHostProp.Services;
            //_scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            //_mapper = _scope.ServiceProvider.GetRequiredService<IMapper>();
        }

        public static T Resolve<T>()
        {
            if (_serviceProvider == null) _serviceProvider = ServiceCollection.BuildServiceProvider();

            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
