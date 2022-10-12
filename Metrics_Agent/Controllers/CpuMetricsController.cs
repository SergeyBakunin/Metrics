using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Metrics_Agent.Controllers
{
    [Route("api/metrics/cpu")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {

        [HttpGet("from/{fromTome}/to/{toTime}")]
        public IActionResult GetCpuMetrics([FromRoute]TimeSpan fromrTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
}
