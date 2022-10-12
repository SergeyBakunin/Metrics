using Metrics_Agent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_Agent_Tests
{
    public class DotnetMetricsControllerTests
    {
        private DotnetMetricsController _dotnetMetricsController;

        public DotnetMetricsControllerTests()
        {
            _dotnetMetricsController = new DotnetMetricsController();
        }

        [Fact]
        public void GetDotnetMetrics_ReturnOk()
        {
            // Подготовка данных для тестирования
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            // Исполнение тестируемого метода
            var result = _dotnetMetricsController.GetDotnetMetrics(fromTime, toTime);

            //Подготовка эталлоного результата, проверка результата
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
