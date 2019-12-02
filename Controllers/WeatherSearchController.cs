using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace API_Workshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherSearchController : ControllerBase
    {
         private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Cities = new[]
        {
            "Houston", "Los Angeles", "New York", "San Francisco", "Dallas", "Des Moines"
        };

        public IEnumerable<WeatherForecast> weather()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                City = Cities[rng.Next(Cities.Length)],
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

     [HttpGet]
     [Route("{negativedegree}")]
     public IEnumerable<WeatherForecast> GetTemperature() {
         
        return weather().Where(t => t.TemperatureC < 0).ToArray();
     }
    }
}