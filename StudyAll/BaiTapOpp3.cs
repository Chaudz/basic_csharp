using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{   
   /* interface IBacSi
    {
         double LuongHangThang();
    }

    class chau : IBacSi
    {
       
    }*/
    public class BaiTapOpp3
    {
        static bool checkout(string s)
        {
            string[] array = new string[] { "(", ")", "{", "}", "[", "]" };
            
            if(s.Length == 2)
            {
                string firstLetter = s[0].ToString();
                string lastLetter = s[1].ToString();
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0 && firstLetter == array[i])
                    {
                        return lastLetter == array[i+1];
                    }
                }
            }
            
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(checkout("[]"));
            Console.Read();
        }
    }
}
