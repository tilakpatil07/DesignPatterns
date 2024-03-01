using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Singleton
{
    public class ConfigurationDetails
    {
        public string apiKey { get; set; }
        public string baseUrl { get; set; }
        public int timeout { get; set; }
        public string logLevel { get; set; }



    }
}
