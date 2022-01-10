using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.IO;

namespace CarDealership
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Name of Car: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Price of Car: ");
            int Cost = Int32.Parse(Console.ReadLine());

            Car newCar = new Car(Name, Cost);

            ImplementBooking nonInterfaceBooking = new ImplementBooking();

            IBooking booking = new ImplementBooking();


            booking.buyCar += new EventHandler<IDisplayEventArgs>(Display);
            booking.BookCar(newCar);

        }

        private static void Display(object sender, IDisplayEventArgs e)
        {
            Console.WriteLine(e.DisplayText);
        }

    }
}
