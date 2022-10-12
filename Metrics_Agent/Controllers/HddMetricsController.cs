using Microsoft.AspNetCore.Mvc;

namespace Metrics_Agent.Controllers
{
    [Route("api/metrics/hdd")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTome}/to/{toTime}")]
        public IActionResult GetHddMetrics([FromRoute] TimeSpan fromrTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
