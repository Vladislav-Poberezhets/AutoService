using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class Worker : Person
    {
        private int salary;
        

        public Worker(string name, int age) : base(name, age)
        {
        }

        public void foldCar (Worker worker,Car car, Wheel wheel, Engine engine)
        {
            Console.WriteLine($"Worker {worker.name} assembles a car {car.Brand}");
        }
        



    }
}
