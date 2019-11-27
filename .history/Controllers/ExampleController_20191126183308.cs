using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Workshop.Controllers {
    [ApiController]
    [Route("/demo/[controller]")]
    public class ExampleController : ControllerBase {
        private readonly ILogger<ExampleController> _logger;
        
    }
}