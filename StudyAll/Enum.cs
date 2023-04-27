using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    enum Color
    {
        RED=6,
        GREEN=2,
        BLUE=3,
        YELLOW
    }
    internal class Enum
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Color.RED); // ouput: 6
            Console.WriteLine((int)Color.YELLOW); // ouput: 4
            Console.WriteLine(Color.GREEN == (Color)2); // True
            int value = (int)Color.YELLOW;
            Console.WriteLine(value);    //4
        }
    }
}
