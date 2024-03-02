using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class AdapterClass : ITarget
    {
        private readonly ThirdPartySystem thirdPartySystem;
        public AdapterClass(ThirdPartySystem ThirdPartySystem)
        {
            this.thirdPartySystem = ThirdPartySystem;
        }
        public List<ThirdPartyData> ProcessData(List<LegacyData> data)
        {

            List<ThirdPartyData> listOfTransactions = new List<ThirdPartyData>();

            foreach(LegacyData legacyData in data) 
            {
                ThirdPartyData thirdPartyData = new ThirdPartyData(legacyData.userID, legacyData.transactionID, legacyData.amount);
                listOfTransactions.Add(thirdPartyData);
            }
            return listOfTransactions;
        }
    }
}
