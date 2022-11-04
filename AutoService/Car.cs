using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class Car
    {
       
        public string Brand { get; set; }
        private string CarColor { get; set; }
        public Car(string brand, string carColor)
        {
            Brand = brand;
            CarColor = carColor;     
        }

        public void ReadyCar(Wheel wheel, Engine engine, Car car)
        {
            Console.WriteLine($"Car {car.Brand} is folded.");
           
        }

    }

    
}
