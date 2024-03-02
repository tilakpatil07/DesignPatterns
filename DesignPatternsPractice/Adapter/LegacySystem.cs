using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class LegacySystem
    {
        public void RequestData()
        {

        }

        public List<LegacyData> SendData()
        {
            LegacyData legacyData1 = new LegacyData(123, "ABC123", 500);
            LegacyData legacyData2 = new LegacyData(124, "ABC124", 800);
            LegacyData legacyData3 = new LegacyData(125, "ABC125", 90000);
            return new List<LegacyData> { legacyData1, legacyData2, legacyData3 };
        }
    }
}
