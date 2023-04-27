using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    public class cunghoangdao
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                int month;
                int day;
                while (true)
                {
                    Console.WriteLine("Nhap ngay");
                    day = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap thang");
                    month = Convert.ToInt32(Console.ReadLine());
                    // tháng 31 ngay : 1,3,5,7,8,10,12
                    if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day > 0 && day <= 31)
                    {
                        break;
                    }
                    // tháng 30 ngay: 4,6,9,11
                    if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 0 && day <= 30)
                    {
                        break;
                    }
                    // thang 2: năm nhuan: 29 ngay , con lai: 28 ngay  
                    if (month == 2)
                    {
                        if (day % 4 == 0 && day > 0 && day < 30)
                        {
                            break;
                        }
                        else if (day > 0 && day < 29)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Vui long dinh dang lai ngay thang");
                    Console.WriteLine("============================");
                }
                switch (month)
                {
                    case 1:
                        if (day >= 20)
                        {
                            Console.WriteLine("Bao Binh");
                        }
                        else
                        {
                            Console.WriteLine("Ma ket");
                        }
                        break;
                    case 2:
                        if (day >= 19)
                        {
                            Console.WriteLine("Song Ngu");
                        }
                        else
                        {
                            Console.WriteLine("Bao Binh");
                        }
                        break;
                    case 3:
                        if (day >= 21)
                        {
                            Console.WriteLine("Bach Duong");
                        }
                        else
                        {
                            Console.WriteLine("Song Ngu");
                        }
                        break;
                    case 4:
                        if (day >= 20)
                        {
                            Console.WriteLine("Kim Ngu");
                        }
                        else
                        {
                            Console.WriteLine("Bach Duong");
                        }
                        break;
                    case 5:
                        if (day >= 21)
                        {
                            Console.WriteLine("Song Tu");
                        }
                        else
                        {
                            Console.WriteLine("Kim Ngu");
                        }
                        break;
                    case 6:
                        if (day >= 22)
                        {
                            Console.WriteLine("Cu Giai");
                        }
                        else
                        {
                            Console.WriteLine("Song Tu");
                        }
                        break;
                    case 7:
                        if (day >= 23)
                        {
                            Console.WriteLine("Su Tu");
                        }
                        else
                        {
                            Console.WriteLine("Cu Giai");
                        }
                        break;
                    case 8:
                        if (day >= 23)
                        {
                            Console.WriteLine("Xu Nu");
                        }
                        else
                        {
                            Console.WriteLine("Su Tu");
                        }
                        break;
                    case 9:
                        if (day >= 23)
                        {
                            Console.WriteLine("Thien Binh");
                        }
                        else
                        {
                            Console.WriteLine("Xu Nu");
                        }
                        break;
                    case 10:
                        if (day >= 23)
                        {
                            Console.WriteLine("Ho Cap");
                        }
                        else
                        {
                            Console.WriteLine("Thien Binh");
                        }

                        break;
                    case 11:
                        if (day >= 22)
                        {
                            Console.WriteLine("Nhan Ma");
                        }
                        else
                        {
                            Console.WriteLine("Ho Cap");
                        }
                        break;
                    case 12:
                        if (day >= 22)
                        {
                            Console.WriteLine("Ma Ket");
                        }
                        else
                        {
                            Console.WriteLine("Nhan Ma");
                        }
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("============================");
                Console.WriteLine("Nhap phim bat ki de tiep tuc, n de thoat");
                choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    break;
                }
            } while (true);
        }
    }
}
