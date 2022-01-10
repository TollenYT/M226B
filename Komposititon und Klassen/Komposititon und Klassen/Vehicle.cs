using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komposititon_und_Klassen
{
    public abstract class Vehicle // abstract class so that you can't make an instance of it since it's the base class
    {

        // properties
        public string VehicleName { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Vehicle(string vehicleName, double length, double height, double width)
        {
            VehicleName = vehicleName;
            Length = length;
            Height = height;
            Width = width;
        }

        // virtual method
        public virtual void PrintInfo()
        {
            Console.WriteLine("Here some infos about the vehicle: ");
        }
    }
}
