using System;

namespace ISP.Vehicles
{
    class Motorcycle : IVehicles
    {
        public string color { get; set; }
        public int year { get; set; }
        public double engine { get; set; }

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando moto ano {year}, {engine} cilindradas, cor {color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
