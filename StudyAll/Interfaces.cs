using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    interface IAnimal
    {
        void eat(); 
    }
    interface IWalker
    {
        void walk();
    }
    class Cat : IAnimal, IWalker
    {
        public void eat() {
            Console.WriteLine("Cat is eating ....");
        }
        public void walk() {
            Console.WriteLine("Cat is walking ...");
        }
    } 
    class Interfacesfas
    {
       static void Main(string[] args)
        {
            IAnimal cat1 = new Cat(); ;
            cat1.eat();
            IWalker cat2 = new Cat();
            cat2.walk();
            Cat cat3 = new Cat();
            cat3.eat();
            cat3.walk();
        }
    }
}
