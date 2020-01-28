using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTest.Destination;
using AutoMapperTest.Repositories;
using AutoMapperTest.Source;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AutoMapperTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;
        private readonly IUrlItemRepository<UrlItem, UrlItemDto> _urlItemRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper, IUrlItemRepository<UrlItem, UrlItemDto> urlItemRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _urlItemRepository = urlItemRepository;
          
        }

        [HttpGet]
        public async  Task<IEnumerable<WeatherForecast>> Get()
        {
            var rng = new Random();
            return await Task.Run( ()=>
            {
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Now.AddDays(index),
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    })
                    .ToArray();
            });
        }
    }
}
