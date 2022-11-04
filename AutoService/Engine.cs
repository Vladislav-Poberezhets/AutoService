using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class Engine
    {
        private string name { get; set; }
        private double Power { get; set; } 
        private double Capasity { get; set; }
        private double FuelConsumption { get; set; }

        public Engine(string name,double power, double capasity, double fuelConsumption)
        {
            
        }
        public void EnginePrint(Engine engine)
        {
            Console.WriteLine($"Engine: {engine.name}, power: {engine.Power}, capasity {engine.Capasity}, fuel consumption: {engine.FuelConsumption}");
        }
    }
}
