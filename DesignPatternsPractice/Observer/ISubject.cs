using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Observer
{
    public interface ISubject
    {
        public static void AddDevice(IObserver observer) { }
        public static void RemoveDevice(IObserver observer) { }
        public static void NotifyDevices() { }

    }
}
