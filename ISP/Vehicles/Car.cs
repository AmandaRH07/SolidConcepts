using System;

namespace ISP.Vehicles
{
    class Car : IVehicles
    {
        public string color { get; set; }
        public int year { get; set; }
        public double engine { get; set; }
        public int seats { get; set; }
        public int doors { get; set; }

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"Criando carro ano {year}, motor {engine}, cor {color}");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
