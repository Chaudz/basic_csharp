using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{  

    abstract class Food:Test
    {
        public abstract void origin();
    }
    class BimBim: Food
    {
        public override void origin()
        {
            Console.WriteLine("Origin from China");
        }
    }
    class Tokbokki:Food {
        public override void origin()
        {
            Console.WriteLine("Origin from Korea");
        }
    }
    class Animal{
        
        public virtual void speak()
        {
            Console.WriteLine("Animal is speaking ....");
        }
    }
    class Dog:Animal
    {
        public void speak() {
            Console.WriteLine("Dong is speaking ...");
        }    
    }
    class Cat:Animal
    {
        public override void speak() {
            Console.WriteLine("Cat is speaking ...");
        }
    }
    internal class DaHinh
    {
        static void Main(string[] args)
        {
            Animal dog1 = new Dog();
            dog1.speak(); // Animal is speaking ... 
            Animal cat1 = new Cat();
            cat1.speak(); // cat is speaking ....
            Food food1 = new Tokbokki();
            food1.origin(); // Origin from Korea
      
        }
        
    }
}
