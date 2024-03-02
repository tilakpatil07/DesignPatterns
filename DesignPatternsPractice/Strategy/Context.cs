using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    public class Context
    {
        private IPaymentMethod payment;

        public Context(IPaymentMethod payBy)
        {
            this.payment = payBy;
        }

        public void SetStrategy(IPaymentMethod paymentMethod)
        {
            this.payment = paymentMethod;
        }

        public void PayMoney()
        {
            payment.Pay();
        }
    }
}
