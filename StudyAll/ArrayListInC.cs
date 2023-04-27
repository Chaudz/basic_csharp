using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    internal class ArrayListInC
    {
        static void Main(string[] args)
        {
            ArrayList myArr = new ArrayList(4);
            myArr.Add(1);
            myArr.Add(2);
            myArr.Add(5);
            myArr.Add(4);
            Console.WriteLine(myArr[1]); //ouput: 2
            ArrayList myArr2 = new ArrayList(myArr);
            myArr2[1] = 7;
            Console.WriteLine(myArr2[1]); //ouput: 7
            
            // sắp xếp
            myArr2.Sort();
            foreach (var item in myArr2) {
                Console.Write(item + " ");  // 1 4 5 7
            }
            Console.WriteLine();

            //
            ArrayList newArr1 = new ArrayList();
            newArr1.Add(1);
            newArr1.Add(9);
            newArr1.Add("Chau");
            newArr1.Add(34.2);
            newArr1.Add(34);
            newArr1.Add(7);
            double sum = 0;
            foreach(object item in newArr1)
            {
                if(item is double|| item is int)
                {
                    sum += Convert.ToDouble(item);
                }
            }
            Console.WriteLine(sum);

        }
    }
}
