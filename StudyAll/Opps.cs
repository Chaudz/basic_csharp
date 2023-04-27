using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    class Cat
    {
        int id;
        string name;
        string color; // ko khai bao thi pham vi truy cap se la private
        int age;
        public int AGE
        { 
            get
            {
                return age;

            }
            set
            {
                if (value >0 && value <150)
                {
                    age = value;
                };
            }
        }
        public Cat() // ko khai bao thi pham vi truy cap se la private
        {

        }
        public Cat(int id, string name, string color)
        {
            this.id = id;
            this.name = name;
            this.color = color;
        }
        public void sayHello()
        {
            Console.WriteLine(a.huhi);
            Console.WriteLine("Hello");
        }
    }
    class Opps
    {
        public void huhi()
        {
            Console.WriteLine("my name is chau");
        }
        static void Main(string[] args)
        {
            var YellowCat = new Cat();
            YellowCat.sayHello();
            YellowCat.AGE = 15;
            Console.WriteLine(YellowCat.AGE);
        }
    }
}
