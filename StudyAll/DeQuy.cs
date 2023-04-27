using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class DeQuy
    {
        // chia het cho 3 hoac 5
        // 15/ 3 =5
        // 15 /5 = 3
        // 15/15 =1
        // sum = 8 -1 =7

        public static int giaiThua(int n)
        {   if (n == 1) return 1;
            return n * giaiThua(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(giaiThua(3));
            int i = -2147483647;
            Console.WriteLine(Math.Abs(i));
        }
    }
}
