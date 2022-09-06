using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AutoService
    {
        public void Repair(Vehicle vehicle)
        {
            if (vehicle.Model.ToLower().StartsWith("bmv"))
            {
                Console.WriteLine("Скидка постоянному клиенту :) ");
            }
            Console.WriteLine("Все сделано, можно ехать");
        }
    }
    class Vehicle
    {
        public virtual string? Model { get; } = "Lada";
        public virtual string? VehicleColor { get; set; } = "Red";
        public virtual double EngineVolume { get { return new Engine().EngineVolume; } }
        public virtual string WheelColor { get; set; } = new Wheel().WheelColor;
        public virtual void StartEngine()
        {
            new Engine().StartEngine();
        }

        public virtual void Drive()
        {
            Console.WriteLine("дррррр, дрррр, дрр");
        }
    }

    class Engine
    {
        public double EngineVolume { get; set; } = 1.5;
        public void StartEngine() => Console.WriteLine("Заводим машину");
    }

    class Wheel
    {
        public string WheelColor { get; } = "Yellow";
    }

}
