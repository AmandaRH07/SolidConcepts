using OCP.Vehicles;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Car car = new Car("Blue", 2024, 2.0, 5, 4);
            }
            else
            {
                Motorcycle motorcycle = new Motorcycle("Blue", 2024, 250);
            }
            Console.ReadLine();
        }
    }
}
