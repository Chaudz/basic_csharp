using System;


namespace StudyAll
{
    public class ShowData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========");
            int a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double sum = a + b + c;
            // opinion 1
            Console.WriteLine("sum " + a + "," + b + " is: " + sum);
            // opinion 2
            Console.WriteLine("sum {0},{1} is: {2}", a, b, sum);
            // opinion3
            Console.WriteLine($"sum {a},{b} is: {sum}");

        }
    }
}
