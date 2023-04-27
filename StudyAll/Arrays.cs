using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6] { 1, 20, 3, 9, 5, 8 };
            // fori
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            // foreachss
            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("======");
        
            int[] test = new int[] {2,3,4};
             Console.WriteLine(test.Length);
            int[] chau = test;
        
            foreach(int n in test)
            {
                Console.Write(n + " ");
            }

            chau[1] = 190;
            Console.WriteLine("====");
                foreach (int n in test)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            int[] numberBooks = { 2,5,1,6,1,4};
            // Một số chức năng array
            Array.Sort(numberBooks); // sắp xếp từ nhỏ để lớn
            foreach(int n in numberBooks)
            {
                Console.Write(n +" ");
            }
            Console.WriteLine();
            // muốn sắp xếp từu lớn đến bé thì dùng sort rồi dùng reverse
            Array.Reverse(numberBooks);
            foreach (int n in numberBooks) {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            int[] listSuitcase = {4,5,2,67,2,2 };
            Array.Clear(listSuitcase, 0, listSuitcase.Length); // (array,vitristart,chieudaireset)
            foreach (int n in listSuitcase)
            {
                Console.Write(n +" ");
            }
            Console.WriteLine();
        }
       
    }
}
