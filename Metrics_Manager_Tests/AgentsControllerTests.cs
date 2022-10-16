﻿using Metrics_Manager.Controllers;
using Metrics_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics_Manager_Tests
{
    public class AgentsControllerTests
    {
        private AgentsController _agentsController;
        private AgentPool _agentPool;

        public AgentsControllerTests()
        {
            _agentPool = AgentPool.Instanse;
            _agentsController = new AgentsController(_agentPool);

        }

        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(25)]
        public void RegisterAgentTest(int agentId)
        {
            AgentInfo agentInfo = new AgentInfo() { AgentId = agentId, Enable = true};
            _agentsController.RegisterAgent(agentInfo);
            Assert.IsAssignableFrom<AgentInfo>(agentInfo);
        }
    }
}
