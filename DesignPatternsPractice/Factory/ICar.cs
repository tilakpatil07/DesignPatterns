using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Factory
{
    public interface ICar
    {
        public double getEngineSize();
        public int getNoOfSeats();
        public double getFuelEfficiency();
    }
}
