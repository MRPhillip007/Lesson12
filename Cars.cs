using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bmw : Vehicle
    {
        override public string? Model { get; }
        public override double EngineVolume { get; }
        public override string WheelColor { get; set; }
        override public string? VehicleColor { get; set; }

        public Bmw(string model, int engineVolume, string? vehicleColor, string wheelColor) : base()
        {
            Model = model;
            EngineVolume = engineVolume;
            VehicleColor = vehicleColor;
            WheelColor = wheelColor;
        }

        public override void StartEngine()
        {
            Console.WriteLine("Двигатель завелся не на шутку");
        }

        public override void Drive()
        {
            Console.WriteLine("Ездим легко и непринужденно. ");
        }
    }
}
