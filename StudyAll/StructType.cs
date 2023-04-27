using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    interface IWeather
    {

    }
    public ref struct MutablePoint
    {
        public ref int test; // c#11 có thể khai báo thuộc tính ref trong ref struct
        public int X { get; set; }
        public int Y { get; set; }

        public MutablePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
    }
    public ref struct Person
    {
        public string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name; ;
            this.age = age;
        }
        public void print()
        {
            Console.WriteLine($"Person has name: {name} and age: {age}");
        }
    }
    internal class StructType
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Ngan",16);
            p1.print();
            Person p2 = p1;
            p2.name = "Chau";
            p2.print();

            // Animal
            MutablePoint m1 = new MutablePoint(3,5);
            Console.WriteLine("Before: "+ m1.X+ " " + m1.Y);
            m1.Move(1, 2);
            Console.WriteLine("After: " + m1.X + " " + m1.Y);

        }
    }
}
