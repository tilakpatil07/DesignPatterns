using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    public class PaymentByCrypto:IPaymentMethod
    {
        public double paymentCoins;
        public string transactionId;

        public double CurrencyToCrypto(int amount)
        {
            return amount / 8.9;
        }
        public PaymentByCrypto(int amount, string transactId)
        {
            this.paymentCoins = CurrencyToCrypto(amount);
            this.transactionId = transactId;
        }

        public void Pay()
        {
            Console.WriteLine("Paid @" + paymentCoins + " through CryptoCoins !");
            Console.WriteLine("Transaction Id: " + transactionId);

        }
    }
}
