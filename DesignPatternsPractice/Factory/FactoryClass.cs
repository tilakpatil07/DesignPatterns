using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Factory
{
    public static class FactoryClass
    {
        public static void CarDetails(ICar car)
        {
            Console.WriteLine("Engine Size: " + car.getEngineSize());
            Console.WriteLine("Number of Seats: " + car.getNoOfSeats());
            Console.WriteLine("Fuel Efficiency: " + car.getFuelEfficiency());
        }
    }
}
