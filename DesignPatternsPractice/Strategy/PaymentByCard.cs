using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    internal class PaymentByCard:IPaymentMethod
    {
        public int paymentAmount;
        public string transactionId;

        public PaymentByCard(int amount, string transactId)
        {
            this.paymentAmount = amount;
            this.transactionId = transactId;
        }

        public void Pay()
        {
            Console.WriteLine("Paid $" + paymentAmount + " through Card !");
            Console.WriteLine("Transaction Id: " + transactionId);

        }
    }
}
