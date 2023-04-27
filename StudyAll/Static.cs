using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    class Color
    {   
        public void sayHello()
        {
            Console.WriteLine("Hello world!!!!!");
        }
        public static void sayHello2()
        {
            Console.WriteLine("Hello world!!!!!");
        }
        static Color()
        {

        }
    }
    static class TienIch
    {
        public static long LyThua(int a, int b)
        {
            long result = 1;
            for(int i =0; i< b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
    class Employee
    {
        public static int COUNT =0;
        private float salary;

        public Employee() {
            COUNT++;
        }
        
        public void printCount()
        {
            Console.WriteLine(COUNT);
        }

        public float Salary
        {
            get => salary;
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
            }
        }
    }
    internal class Static
    {
       static void Main(string[] args) {
            var emp1 = new Employee();
            emp1.printCount();
            var emp2 = new Employee();
            emp2.printCount();
            Console.WriteLine(TienIch.LyThua(3,3));
            var color1 = new Color();
            color1.sayHello();
       }
        
    }
}
