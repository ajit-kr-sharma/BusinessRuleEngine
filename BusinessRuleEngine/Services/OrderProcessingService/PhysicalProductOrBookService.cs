using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Services.OrderProcessingService
{
    public class PhysicalProductOrBookService : OrderProcessing<PhysicalProductOrBookModel>
    {
        protected override PaymentStatus ProcessOrder(PhysicalProductOrBookModel model)
        {
            // Logic for Agent payment commission and update the model

            if (model.AgentName != null)
            {
                return new PaymentStatus {
                    IsOrderProcessed = true,
                    Message = "Commission payment is generated to the agent"
                };
            }

            return new PaymentStatus {
                IsOrderProcessed = false,
                Message = string.Empty
            }; ;
        }
    }
}
