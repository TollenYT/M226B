using System;
using System.Runtime.CompilerServices;

namespace Komposititon_und_Klassen
{
    class Program
    {
        public interface IDrawable
        {
            void draw();
        }
        public class Rectangle : IDrawable
        {
            public void draw()
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        public class Circle : IDrawable
        {
            public void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }

        public interface IConsole
        {
            void Write(string value);
            void WriteLine(string value);
            string ReadLine();
        }
        public class ProductionConsole : IConsole
        {
            public void Write(string value)
            {
                System.Console.Write(value);
            }

            public void WriteLine(string value)
            {
                System.Console.WriteLine(value);
            }

            public string ReadLine()
            {
                return System.Console.ReadLine();
            }
        }
        public class SportsTeam
        {
            public string Sport { get; set; }
            public string TeamName { get; set; }

            private IConsole Console { get; }
                
            public SportsTeam(string sport, string teamName, IConsole console)
            {
                if (console == null)
                    throw new ArgumentNullException(nameof(console));

                Sport = sport;
                TeamName = teamName;
                Console = console;
            }

            public void PrintTeamInfo()
            {
                Console.WriteLine(Sport + " - " + TeamName);
            }

            public void UpdateTeam()
            {
                Console.Write("Enter new team name --> ");
                var newName = Console.ReadLine();
                TeamName = newName;
            }
        } 
        static void Main(string[] args)
        {
            IDrawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();

            SportsTeam sportsTeam = new SportsTeam("fussball", "fch", new ProductionConsole());

            sportsTeam.PrintTeamInfo();
            sportsTeam.UpdateTeam();
            sportsTeam.PrintTeamInfo();

            //// Create Car object
            //Car car = new Car("Mercedes", 4, true, 4.90, 2.10, 1.65, "Mercedes-AMG One");
            //// Print property info
            //car.PrintInfo();

            //// Create DataMigrator object
            //DataMigrator dataMigrator = new DataMigrator();
            //// Execute "Log" method from Logger class in another class
            //dataMigrator.Migrate();



        }
    }
}
