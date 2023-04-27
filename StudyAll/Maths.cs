using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class Maths
    {
      static void Main(string[] args)
        {

            Console.WriteLine(Math.Ceiling(3.4)); // làm tròn lên số nguyên gần nhất
            Console.WriteLine(Math.Floor(3.7)); // làm tròn xuống số nguyên gần nhất
            Console.WriteLine(Math.Round(3.4)); // 3 làm tròn tới số nguyên gần nhất
            Console.WriteLine(Math.Truncate(3.6)); // lấy phần nguyên bỏ phần thật phân
            Console.WriteLine(Math.Abs(-3.5)); // giá trị tuyệt đối
            Console.WriteLine(Math.Sqrt(4)); // căn bậc 2
            Console.WriteLine(Math.Pow(3,3)); // tính mũ
        }
    }
}
