using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class VarKeyword
    {
        public static void change(ref int age)
        {
            age = 200;
        }
        static void Main(string[] args)
        {
            var age = 100;
            Console.WriteLine(age); 
            change(ref age);
            Console.WriteLine( age);
        }
    }
}
