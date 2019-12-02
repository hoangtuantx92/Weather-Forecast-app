using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
 using Newtonsoft.Json;

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
     [HttpGet]
     [Route("{city}")]
      public async Task<IActionResult> City(string city) {
          using (var client = new HttpClient())
          {
              try
              {
                client.BaseAddress = new Uri("http://api.openweathermap.org");
                var res = await client.GetAsync($"/data/2.5/weather?q={city}&appid=YOUR_API_KEY_HERE&units=metric");
                res.EnsureSuccessStatusCode();

                var result = await res.Content.ReadAsStringAsync();
                var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(result);
                return Ok(new {
                    Temp = rawWeather.Main.Temp,
                    Summary = string.Join(",", rawWeather.Weather.Select(x => x.Main)),
                    City = rawWeather.Name
                });
              }
              catch (HttpRequestException HttpRequestException)
              {
                  return BadRequest($"Error getting weather from OpenWeahter");
              }
          }
      }
    }
}