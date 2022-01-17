using System;

namespace Interfaces
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public int AgeCalculate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    public class PersonStub : IPerson
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public int AgeCalculate(int number1, int number2)
        {
            return 5;
        }
    }
    public interface IPerson
    {
        string Name { get; set; }
        string Firstname { get; set; }
        int AgeCalculate(int number1, int number2);
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPerson item = new Person();
            IPerson Stubitem = new PersonStub();

            Console.WriteLine(item.AgeCalculate(5, 10));
            Console.WriteLine(Stubitem.AgeCalculate(0, 0));
        }
    }
}
