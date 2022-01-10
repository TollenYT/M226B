using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komposititon_und_Klassen
{
    public class Car : Vehicle
    {
        public string Brand { get; set; }
        public int WheelCount { get; set; }
        public bool AreWindowsDarkened { get; set; }

        public Car(string brand, int wheelCount, bool areWindowsDarkened, double length, double width, double height, string vehicleName) : base(vehicleName, length, height, width)
        {
            Brand = brand;
            WheelCount = wheelCount;
            AreWindowsDarkened = areWindowsDarkened;
        }

        // override method with base method
        public override void PrintInfo()
        {
            base.PrintInfo();
            // use of "base" and "this" to make it easily visible what is from the base class and what isn't
            Console.WriteLine($"This vehicle is a car.\nVehicle name: {base.VehicleName}\nBrand: {(this.Brand)}\nLength: {base.Length}\nWidth: {base.Width}\nHeight: {base.Height}\nWheel count: {this.WheelCount}\nAre windows darkened?: {this.AreWindowsDarkened}");
        }
    }
}
