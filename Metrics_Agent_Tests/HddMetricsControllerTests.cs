using Metrics_Agent.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_Agent_Tests
{
    public class HddMetricsControllerTests
    {
        private HddMetricsController _hddMetricsController;

        public HddMetricsControllerTests()
        {
            _hddMetricsController = new HddMetricsController();
        }

        [Fact]
        public void GetHddMetrics_ReturnOk()
        {
            // Подготовка данных для тестирования
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            // Исполнение тестируемого метода
            var result = _hddMetricsController.GetHddMetrics(fromTime, toTime);

            //Подготовка эталлоного результата, проверка результата
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
