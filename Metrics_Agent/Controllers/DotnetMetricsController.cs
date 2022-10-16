using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Metrics_Agent.Controllers
{
    [Route("api/metrics/dotnet/errors-count")]
    [ApiController]
    public class DotnetMetricsController : ControllerBase
    {
        [HttpGet("from/{fromTome}/to/{toTime}")]
        public IActionResult GetDotnetMetrics([FromRoute] TimeSpan fromrTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

        public object GetDotnetuMetrics(TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }
    }
}
