using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class ThirdPartySystem
    {
        public void FetchData()
        {

        }

        public void UploadData(List<ThirdPartyData> list)
        {
            foreach(ThirdPartyData data in list)
            {
                Console.WriteLine("User ID: " + data.userIdentifier);
                Console.WriteLine("Transaction ID: " + data.transactionIdentifier);
                Console.WriteLine("Transaction Amount: " + data.transactionAmount);
                Console.WriteLine();
            }
        }
    }
}
