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
    public class MembershipService : OrderProcessing<MembershipModel>
    {
        protected override PaymentStatus ProcessOrder(MembershipModel model)
        {

            // logic implementation
            // If Payment is done then activate the membership and sent a mail to user.

            if (model.MembershipName != null)
            {
                model.Status = true;

                return new PaymentStatus {
                    isOrderProcessed = true,
                    message = "Membership Activated",
                    isNotificationSent = true
                };
            }

            return new PaymentStatus
            {
                isOrderProcessed = false,
                message = "Membership Not Activated",
                isNotificationSent = false
            };
        }
    }
}
