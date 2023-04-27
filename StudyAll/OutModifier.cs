using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class OutModifier
    {
        static void outAgrExample(out int number,out int number2) // nó được truyền theo tham chiếu
        {
            number = 22;
            number2 = 33;
        }

        static void Main(string[] args)
        {
            int numberA; // không cần gán
            int numberB = 4;
            outAgrExample(out numberA,out numberB);
            Console.WriteLine(numberA); 
            Console.WriteLine(numberB);
        }
    }
}
