using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Factory
{
    public class Sedan : ICar
    {
        public double getEngineSize() 
        {
            return 3.0;
        }
        public int getNoOfSeats()
        {
            return 5;
        }
        public double getFuelEfficiency()
        {
            return 20.5;
        }      
    }

    public class SUV : ICar
    {
        public double getEngineSize()
        {
            return 5.0;
        }
        public int getNoOfSeats()
        {
            return 8;
        }
        public double getFuelEfficiency()
        {
            return 15.0;
        }
    }

    public class HatchBack : ICar
    {
        public double getEngineSize()
        {
            return 2.7;
        }
        public int getNoOfSeats()
        {
            return 4;
        }
        public double getFuelEfficiency()
        {
            return 25;
        }
    }
}

