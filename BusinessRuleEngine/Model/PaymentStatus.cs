using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Model
{
    public class PaymentStatus
    {
        public string message { get; set; }
        public bool isOrderProcessed { get; set; }

        public bool isNotificationSent { get; set; }
    }
}
