using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Metrics_Agent.Controllers
{
    [Route("api/metrics/network")]
    [ApiController]
    public class NetworkMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTome}/to/{toTime}")]
        public IActionResult GetNetworkMetrics([FromRoute] TimeSpan fromrTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
