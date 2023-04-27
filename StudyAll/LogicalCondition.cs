using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class LogicalCondition
    {
        static int Sum(int a, int b) {
            return a+b;
        }
        static int Mult(int a, int b)
        {
            return a * b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static double Div(int a, int b)
        {
            return (double) a / b;
        }
        static void Menu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("==Choice 1: Sum a,b====");
            Console.WriteLine("==Choice 2: Sub a,b====");
            Console.WriteLine("==Choice 3: Mult a,b===");
            Console.WriteLine("==Choice 4: Dev a,b====");
        }

        static void Main(string[] args)
        {   
            // tính tổng, hiệu, nhân,chia;
            bool isValidInput = true;
            int checkInt;
            Console.WriteLine("Enter number int a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number int b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (isValidInput)
            {
                Menu();
                Console.WriteLine("Please choice a opinion: ");
                string choice = Console.ReadLine();
                isValidInput = int.TryParse(choice, out checkInt); // check xem có phải kiểu int không
                if(isValidInput )
                {
                   
                    switch (Convert.ToInt32(choice))
                    {
                        case 1:
                            Console.WriteLine("Sum a,b is: "+Sum(a, b));
                            break;
                        case 2:
                            Console.WriteLine("Sub a,b is: " + Sub(a, b));
                            break;
                        case 3:
                            Console.WriteLine("Mult a,b is: " + Mult(a, b));
                            break;
                        case 4:
                            Console.WriteLine("Dev a,b is: " + Div(a, b));
                            break;
                        default:
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter an integer.");
                    isValidInput = true;
                }
            }
        }
    }

   
}
