using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class RefModifier
    {
        static void refArgExample(ref string name,ref int age) {
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Age: "+ age);
        }
        static void Main(string[] args)
        {
            string name= default;
            int age=20; // phải gán
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine(age);
            Console.WriteLine("==========");
            refArgExample(ref name,ref age);
        }
    }
}
