using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    public class PayByPaypal : IPaymentMethod
    {
        public int paymentAmount;
        public string transactionId;

        public PayByPaypal(int amount, string transactId)
        {
            this.paymentAmount = amount;
            this.transactionId = transactId;
        }

        public void Pay()
        {
            Console.WriteLine("Paid $" + paymentAmount + " through PayPal !");
            Console.WriteLine("Transaction Id: " + transactionId);

        }
    }
}
