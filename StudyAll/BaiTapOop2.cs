using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    interface IEat
    {
         void eat();
    }
    interface IWalk
    {
        void walk();
    }
    class Person: IWalk, IEat
    {   
        public void eat() {
            Console.WriteLine("I am walking....");
        }
        public void walk() {
            Console.WriteLine("I am eating....");
        }
    }
    internal class BaiTapOop2
    {
        static void Main(string[] args) {
            var p1 = new Person();
            p1.walk();
            p1.eat();
        } 
    }
}
