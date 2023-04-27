using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudyAll
{   
    interface test
    {
        void chat()
        {
            int a = 2;
            Console.WriteLine("cdshfadsu");   
        }
    }
    internal class RegularExpression
    {
        static void Main(string[] args)
        {
            string email = "example@gmaila.com";
            bool isValid = Regex.IsMatch(email, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$");
            Console.WriteLine(isValid);
            /*Regex rg = new Regex(@"\d");
            Match result = rg.Match("chaubui324324");
            Console.WriteLine(result);
            foreach(Match item in rg.Matches("chaubui3342533"))
            {
                Console.WriteLine(item.ToString());
            }*/
        }
    }
}
