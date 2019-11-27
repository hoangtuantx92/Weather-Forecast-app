using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Workshop.Controllers {
    [ApiController]
    [Route("/api/[controller]")]
    public class ExampleController : ControllerBase {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> logger){
            _logger = logger;
        }

        [HttpGet]
        public string Get(){
            return "Hello World!";
        }
    }
}