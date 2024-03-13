using OCP.Vehicles;
using System;

namespace OCP
{
    class Vehicle : IVehicle
    {
        protected string color;
        protected int year;
        protected double engine;
      
        public Vehicle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Starting engines");
        }
    }

}
