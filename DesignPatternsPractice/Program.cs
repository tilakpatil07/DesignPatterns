using DesignPatternsPractice.Adapter;
using DesignPatternsPractice.Facade;
using DesignPatternsPractice.Factory;
using DesignPatternsPractice.Observer;
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
            /*
            FacadeClass.StartMovieNight();
            */

            //Observer Implementation
            /*
            //Subscriber instnce
            MotionSensor motionSenor = new MotionSensor();

            //Adding subscriber(subscribing the subject) using the observer instance
            Devices observer1 = new Devices("Light");
            observer1.AddSubscriber(motionSenor);

            Devices observer2 = new Devices("Security Camera");
            observer2.AddSubscriber(motionSenor);

            Devices observer3 = new Devices("Door Camera");
            observer3.AddSubscriber(motionSenor);

            //Adding device using the subject/subsriber instance
            Devices observer4 = new Devices("Siren");
            motionSenor.AddDevice(observer4);

            //Notifying all the observers connected to the subscriber
            motionSenor.NotifyDevices();

            //Removing observer using subject/subscriber instance
            motionSenor.RemoveDevice(observer4);

            //Removing subscriber (unsubscribing the subject) using observer instance
            observer3.RemoveSubscriber(motionSenor);
            */

            //Adapter Implementation
            /*
            LegacySystem legacySystem = new LegacySystem();
            ThirdPartySystem thirdPartySystem = new ThirdPartySystem();
            AdapterClass adapter = new AdapterClass(thirdPartySystem);

            List<LegacyData> legacyDataList = legacySystem.SendData();

            thirdPartySystem.UploadData(adapter.ProcessData(legacyDataList));
            */


            //Factory Implementation
            string carType = Console.ReadLine();
            ICar car = null;
            if(carType == "Sedan")
            {
                car = new Sedan();
                FactoryClass.CarDetails(car);
            }
            else if(carType == "SUV")
            {
                car = new SUV();
                FactoryClass.CarDetails(car);
            }
            else if(carType == "HatchBack" || carType == "Hatchback")
            {
                car = new HatchBack();
                FactoryClass.CarDetails(car);   
            }
            else
            {
                Console.Write("Invalid Car Type !!");
            }
        }
    }
}