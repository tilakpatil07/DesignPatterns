using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Singleton
{
    sealed class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static int instanceCounter = 0;

        List<ConfigurationDetails> listofConfigDetails = new List<ConfigurationDetails>();

        public void AddConfigDetails(ConfigurationDetails configuration)
        {
            listofConfigDetails.Add(configuration);
            Console.WriteLine("Number of config data inserted:" + listofConfigDetails.Count().ToString());
            Console.WriteLine("Number of Instances created:" + instanceCounter.ToString());
        }


        public static ConfigurationManager getInstance()
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
        private ConfigurationManager()
        {
            instanceCounter++;
        }
    }
}
