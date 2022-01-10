using System;

namespace Interfaces
{
    public class Person : Iasdf
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public void TestMethod()
        {
            int number = 0;
            Console.WriteLine(number);
        }

        public int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    public class PersonStub : Iasdf
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public void TestMethod()
        {

        }

        public int Calculate(int number1, int number2)
        {
            return 5;
        }
    }
    public class Car : Iasdf
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        public void TestMethod()
        {
            int number = 1;
            Console.WriteLine(number);
        }
        public int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    public interface Iasdf
    {
        string Name { get; set; }
        string Firstname { get; set; }
        void TestMethod();
        int Calculate(int number1, int number2);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Iasdf item = new Person();
            Iasdf item2 = new Car();
            item.TestMethod();
            item2.TestMethod();
        }
    }
}
