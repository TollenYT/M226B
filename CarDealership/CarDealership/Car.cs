using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Car
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Car(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
    }
}
