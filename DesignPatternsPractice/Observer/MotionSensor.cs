using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Observer
{
    public class MotionSensor: ISubject
    {
        List<IObserver> connectedDevices = new List<IObserver>();

        public void AddDevice(IObserver observer)
        {
            
            connectedDevices.Add(observer);
            Console.WriteLine("Device Added: " + ((Devices)observer).deviceName);
        }

        public void RemoveDevice(IObserver observer)
        {
            if(connectedDevices.Contains(observer))
            {
                connectedDevices.Remove(observer);
                Console.WriteLine("Device Removed: " + ((Devices)observer).deviceName);
            }
        }

        public void NotifyDevices()
        {
            Console.WriteLine("Notifying All Devices...");
            foreach(IObserver device in connectedDevices)
            {
                device.Update();
            }
        }
    }
}
