using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace API_Workshop.Controllers {
    [ApiController]
    [Route("/api/[controller]")]
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
        public JsonResult Get(){
            return Json(Summaries.List());
        }
    }
}