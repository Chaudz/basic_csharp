using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public readonly struct Test {
       
        public Test(double x, double y) { 
            X = x;
            Y = y;
        }
        public double X { get; init; }
        public double Y { get; init; } // từ khoá init C# 9.0 được đặt ngay từ set để đảm bảo tính readonly
                                        // tức là sau khi khởi tạo thì giá trị được gán và sau đó sẽ khong được thay đổi nữa

    }
    internal class TesstStruct
    {
        public static void Main(string[] args)
        {
            Test t1 = new Test(3,6); 
            t1.X = 1; // sẽ bị lỗi vì init ko cho phép gán như set
            Console.WriteLine(t1.X); 
        }
    }
}
