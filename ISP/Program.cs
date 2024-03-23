using ISP.Vehicles;
using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2024, 4.0, 5, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2024, 600);

            Console.ReadLine();
        }
    }
}
