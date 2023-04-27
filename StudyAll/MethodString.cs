using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class MethodString
    {
        static void Main(string[] args)
        {
            string name = "Chau";
            Console.WriteLine(name.Length); // 
            Console.WriteLine(name.ToLower()); // chuyển về tất cà chữ thường
            Console.WriteLine(name.ToUpper());  // chuyển về tất cả chữ HOA
            Console.WriteLine(name.IndexOf("Ca")); // -1
            Console.WriteLine(name.LastIndexOf("a")); // vị trí a cuối cùng
      
        }
    }
}
