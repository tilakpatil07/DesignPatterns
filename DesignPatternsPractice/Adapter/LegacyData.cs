using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class LegacyData
    {
        public int userID { get; set; }
        public string transactionID { get; set; }
        public int amount { get; set; }

        public LegacyData(int UserID, string TransactionID, int TransactionAmount)
        {
            this.userID = UserID;
            this.transactionID = TransactionID;
            this.amount = TransactionAmount;
        }
    }
}
