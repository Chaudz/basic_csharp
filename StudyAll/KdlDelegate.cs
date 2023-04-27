using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    delegate int Calculate(int a, int b); 
    public class TienIch
    {
        public  int Sum(int a, int b)
        {
            return a + b;
        }
        public  int Sub(int a, int b)
        {
            return a - b;
        }
    } 
    internal class KdlDelegate
    {
        
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine(i);
            Calculate t1 = new Calculate(new TienIch().Sum);
            int sumAB = t1(2,5);
            Console.WriteLine(sumAB);
        } 
    }
}
