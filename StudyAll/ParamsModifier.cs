using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class ParamsModifier
    {
        public static void paramsArgExample(params int[] listNumber)
        {
            Console.WriteLine();
            foreach (int i in listNumber)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            
            paramsArgExample(a, b, c);
        }

    }
}
