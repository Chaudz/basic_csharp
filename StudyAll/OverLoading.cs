using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class OverLoading
    {
        public static int Sum(int a , int b)
        {
            return a + b;
        }
        public static float Sum(int a, float b)
        {
            return a + b;
        }
        public static double Sum(double a, float b) {  
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2.7f,3.6f));
        }
    }
}
