using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace API_Workshop.Controllers {
    [ApiController]
    [Route("/[controller]")]
    public class ExampleController : ControllerBase {
        private readonly ILogger<ExampleController> _logger;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public ExampleController(ILogger<ExampleController> logger){
            _logger = logger;
        }

        [HttpGet]
        public string Get(){
            var rng = new Random();
            WeatherForecast value = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            };
            return JsonSerializer.Serialize(value);
        }
    }
}