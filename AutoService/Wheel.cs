using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public  class Wheel
    {
        private double wheelDiametr { get; set; }

        public Wheel(double wheelDiametr)
        {

        }
        public void WheelPrint (Wheel wheel)
        {
            Console.WriteLine($"Wheel:{wheelDiametr}");
        } 
    }
}
