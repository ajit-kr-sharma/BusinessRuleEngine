using BusinessRuleEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Interface
{
    public interface IOrderProcessing
    {
        PaymentStatus ProcessOrder<T>(T model);
    }
}
