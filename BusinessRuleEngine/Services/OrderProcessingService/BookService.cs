using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Services.OrderProcessingService
{
    public class BookService : OrderProcessing<BookModel>
    {
        protected override PaymentStatus ProcessOrder(BookModel model)
        {
            // logic for Royalty calculation has to be done here
            model.RoyaltyAmount = model.Quantity * model.Price * model.Commission;

            if (model.BookName != null)
            {
                return new PaymentStatus { 
                    isOrderProcessed = true, 
                    message = "Royalty slip created With Amount" + model.RoyaltyAmount,
                    isNotificationSent=true
                };
            }

            return new PaymentStatus { isOrderProcessed = false, message = "No Royalty" }; ;
        }
    }
}
