using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class ThirdPartyData
    {
        public int userIdentifier { get; set; }
        public string transactionIdentifier { get; set; }  
        public int transactionAmount { get; set; }

        public ThirdPartyData(int UserIdentifier, string TransactioIndentifier, int TransactionAmount) 
        { 
            this.userIdentifier = UserIdentifier;
            this.transactionIdentifier = TransactioIndentifier;
            this.transactionAmount = TransactionAmount;
        }
    }
}
