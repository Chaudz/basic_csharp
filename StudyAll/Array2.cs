using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class Array2
    {
        static void Main(string[] args)
        {
            // mảng đa chiều
            int[,] numbers = new int[3, 2] { { 1,2},{3,4 },{ 5,3} };
            foreach(int i in numbers) { 
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for(int i =0; i< numbers.GetLength(0); i++)
            {
                for(int j =0;j< numbers.GetLength(1); j++){
                    Console.Write(numbers[i,j] +" ");
                }
            }
            Console.WriteLine();

            int[,,] listPhone = new int[2, 2, 3] { { { 2,4,2},{2,5,6 } }, { { 43, 4, 2 }, { 32, 35, 6 } } };
            foreach(int i in listPhone)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for(int i =0; i< listPhone.GetLength(0); i++)
            {
                for(int j =0; j < listPhone.GetLength(1); j++)
                {
                    for(int k =0; k < listPhone.GetLength(2);k++)
                    {
                        Console.Write(listPhone[i,j,k] +" ");
                    }
                }
            }
            int[,] test = new int[2, 0] { { },{ } };
        }
    }
}
