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
            if (model.MembershipName != null)
            {
                model.UpgradeStartDate = DateTime.Now;
                model.UpgradeEndDate = DateTime.Now.AddYears(1);
                return new PaymentStatus { 
                    isOrderProcessed = true, 
                    message = "Membership upgraded" 
                };
            }

            return new PaymentStatus { 
                isOrderProcessed = false, 
                message = PaymentOrderType.UpgradeMemebership 
            }; ;

        }
    }
}
