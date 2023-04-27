using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
   
    class baitap
    { 
       /* Dưới 6 tuổi hoặc từ 70 tuổi trở lên là được FREE(trả về 0)

        Từ 6 - 12 tuổi giá vé là 20.000 VND

        Trên 12 tuổi thì đồng giá 50.000 VND*/
        public static float getTicketPrice(int age)
        {
            if(age>0 && age < 150)
            {
                if (age < 6 || age >= 70) return 0;
                else if(age <=12) return 20000;
                else return 50000;
            }
            else{
                Console.WriteLine("Not invalid");
            }
            return -1;

        }
        // sayHello by languages
        public static void sayHello(string language)
        {
            switch (language)
            {
                case "vn":
                    Console.WriteLine("Xin Chao");
                    break;
                case "fr":
                    Console.WriteLine("Bonjour");
                    break;
                case "ja":
                    Console.WriteLine("Konnichiwa");
                    break;
                default:
                    Console.WriteLine("Please enter language");
                    break;
            }
        }
        // xe 7 cho, va 4 cho
        public static int getTaxiCount(int persons)
        {
            if (persons <= 0) return -1;
            if (persons <= 4) return 1;
            return Convert.ToInt32(Math.Ceiling(persons / 7.0));
        }
        // (0 <= n < 1000) 243 : 4=max 
        public static int getMaxDigit(int n)
        {
            int onesNumber = n % 10;
            int tensNumber = (n / 10) % 10;
            int hundredsNumber = n / 100;
            int max=0;
            if (n.ToString().Length == 2)
            { 
                if (onesNumber > max) max = onesNumber;
                if (tensNumber > max) max = tensNumber;
            }
            if (n.ToString().Length == 3)
            {
                if (onesNumber > max) max = onesNumber;
                if (tensNumber > max) max = tensNumber;
                if (hundredsNumber > max) hundredsNumber = max;
            }
            return max;
        }
        public static bool isSymmetricNumber(int n)
        {
            if(n.ToString().Length != 3) return false;
            int onesNumber = n / 100;
            int hundredsNumber = n % 10;
            return onesNumber == hundredsNumber;
        } 
        // thay the nguyen am
        public static void removeVowel(string? s)
        {
            string result = "";
            if(s.Length > 0)
            {
                result = s.Replace("u", "")
                    .Replace("e", "")
                    .Replace("o", "")
                    .Replace("a", "")
                    .Replace("i", "")
                    .Replace("U", "")
                    .Replace("E", "")
                    .Replace("O", "")
                    .Replace("A", "")
                    .Replace("I", "");
            }
            Console.WriteLine(result);
            
        }
        // convert seconds to hour 3674 -->  01: 01: 14
        public static void timeFormat(int seconds) {
            if(seconds<0 || seconds > 86400)
            {
                Console.WriteLine("seconds invalid");
                return;
            }
            const int SECONDS_PER_HOUR = 3600;
            const int SECONDS_PER_MINUTE = 60;
            int hourConverted = seconds / SECONDS_PER_HOUR;
            int minuteConverted = seconds % SECONDS_PER_HOUR / SECONDS_PER_MINUTE;
            int secondsConverted = seconds % SECONDS_PER_HOUR % SECONDS_PER_MINUTE;
            string hourFormat = hourConverted.ToString().Length == 1 ? "0" + hourConverted : hourConverted.ToString();
            string minuteFormat = minuteConverted.ToString().Length == 1 ? "0" + minuteConverted : minuteConverted.ToString();
            string secondFormat = secondsConverted.ToString().Length == 1 ? "0" + secondsConverted : secondsConverted.ToString();
            Console.WriteLine(hourFormat + ":" + minuteFormat + ":" + secondFormat);
           
        }
        static void Main(string[] args) {
            /*Console.WriteLine(getTicketPrice(6));*/
            /*sayHello("fr");*/
            /*Console.WriteLine(getTaxiCount(24));*/
            /*Console.WriteLine(getMaxDigit(63));*/
            /*Console.WriteLine(isSymmetricNumber(222));*/
            /*removeVowel("Chau");*/
            timeFormat(4435);


        }
    }
}
