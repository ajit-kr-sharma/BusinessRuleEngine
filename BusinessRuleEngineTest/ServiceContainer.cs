using BusinessRuleEngine.Interface;
using BusinessRuleEngine.Services.OrderProcessingService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineTest
{
    public static class ServiceContainer
    {
        public static ServiceProvider provider()
        {
            return new ServiceCollection()
             .AddSingleton<IOrderProcessing, MembershipService>()
              .BuildServiceProvider();
        }
    }
}
