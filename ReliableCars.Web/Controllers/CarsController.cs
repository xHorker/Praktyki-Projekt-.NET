using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ReliableCars.Web.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {
  
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/cars")]
        public ActionResult Get() {
            return Ok("Cars!");
        }
    }
}
