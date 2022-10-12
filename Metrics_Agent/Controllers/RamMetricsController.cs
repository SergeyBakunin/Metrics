using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Metrics_Agent.Controllers
{
    [Route("api/metrics/ram/available")]
    [ApiController]
    public class RamMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTome}/to/{toTime}")]
        public IActionResult GetRamMetrics([FromRoute] TimeSpan fromrTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
