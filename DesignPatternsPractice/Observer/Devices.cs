using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Observer
{
     public class Devices : IObserver
     {
        public string deviceName { get; set; }

        public Devices(string DeviceName) 
        {
            this.deviceName = DeviceName;
        }

        public void AddSubscriber(MotionSensor subject)
        {
            subject.AddDevice(this);
        }

        public void RemoveSubscriber(MotionSensor subject)
        {
            subject.RemoveDevice(this);
        }

        public void Update()
        {
            Console.WriteLine("ALERT !! Motion Detected.");
            Console.WriteLine(deviceName + " switched on...");
        }

     }
}
