using System;
using System.Collections.Generic;
using System.Text;

namespace M226HZ3._3
{

    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("digga");
            dog.Name = "digga";

            Dog dog1 = new Dog();
        }


    }
    
    class Animal
    {
        
    }
    
    class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }

    public Dog(){ }
    

    public string Name { get; set; }
        public int Age { get; set; }
    }

    class Cat : Animal
    {

    }
}
