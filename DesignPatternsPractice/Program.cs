using DesignPatternsPractice.Facade;
using DesignPatternsPractice.Singleton;
using System;

namespace DesignPatternsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Singleton Implementation
            /*
            ConfigurationDetails configuration1 = new ConfigurationDetails
            {
                apiKey = "default_api_key1",
                baseUrl = "https://api.example.com",
                timeout = 30,
                logLevel = "info",
            };

            ConfigurationDetails configuration2 = new ConfigurationDetails
            {
                apiKey = "api_key2",
                baseUrl = "https://api.example.org",
                timeout = 45,
                logLevel = "debug",
            };

            ConfigurationManager configInstance1 = ConfigurationManager.getInstance();
            configInstance1.AddConfigDetails(configuration1);

            ConfigurationManager configInstance2 = ConfigurationManager.getInstance();
            configInstance1.AddConfigDetails(configuration2);
            */


            //Facade Implementation
            FacadeClass.StartMovieNight();


        }
    }
}