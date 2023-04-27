using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    internal class ObjectTypecs
    {
        static void Main(string[] args)
        {
            /* int value = 199;
             object newObject1 = value;
             object chau = newObject1;
             newObject1 = 300; // tạo ô nhớ tham chiếu mới
             value = 200;
             Console.WriteLine(value); //200
             Console.WriteLine(newObject1); //300
             Console.WriteLine(chau); // 199*/



            // Khởi tạo biến Value kiểu int (kiểu dữ liệu giá trị)
            int Value = 109;
            /* thực hiện boxing bằng cách:
             * Khởi tạo đối tượng ObjectValue kiểu object 
             * Gán giá trị của biến Value vào ObjectValue */
            object ObjectValue = Value;
            /* thực hiện unboxing bằng cách: 
             * Kiểm tra dữ liệu biến ObjectValue thấy thuộc đúng kiểu int. 
             * Gán giá trị của biến ObjectValue vào biến NewValue bằng cách ép kiểu tường minh. 
             * Biến NewValue sẽ mang giá trị là 109*/
            int NewValue = (int)ObjectValue;

            int[] array = new int[] {2,3,4,5};
            object test = array;
            int[] testArr = (int[])test;
            testArr[2] = 5;
            Console.WriteLine(testArr[2]); //5
            Console.WriteLine(array[2]); //5

        }
    }
}
