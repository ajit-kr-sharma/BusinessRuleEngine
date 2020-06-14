using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessing;
using BusinessRuleEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Services.OrderProcessingService
{
    public class UpgradeMembershipService : OrderProcessing<UpgradeMembershipModel>
    {
        protected override PaymentStatus ProcessOrder(UpgradeMembershipModel model)
        {
            // Implement required logic here
            if (!string.IsNullOrEmpty(model.MembershipName))
            {
                model.UpgradeStartDate = DateTime.Now;
                model.UpgradeEndDate = DateTime.Now.AddYears(1);
                return new PaymentStatus { 
                    IsOrderProcessed = true, 
                    Message = "Membership upgraded" 
                };
            }

            return new PaymentStatus { 
                IsOrderProcessed = false, 
                Message = PaymentOrderType.UpgradeMemebership 
            }; ;

        }
    }
}
