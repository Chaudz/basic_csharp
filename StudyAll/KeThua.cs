using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{
    class Animal
    {
        float height;
        float weight;
        public Animal() { }
        public Animal(float height, float weight)
        {
            this.height = height;
            this.weight = weight;
        }
        public void sayHello()
        {
            Console.WriteLine($"Hello I have height: {height}, weight: {weight}");
        }
    }
    class Cat: Animal {
        
        public Cat():base() { }
        public Cat(float height, float weight):base(height,weight) {
            
        }
        public void sayYes()
        {
            Console.WriteLine("Yes");
        }
        public new void sayHello()
        { 
            Console.WriteLine("Hello");
            base.sayHello();
        }
    }

    internal class KeThua
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.sayHello();
            Animal cat2 = new Cat();
           /* cat2.sayYes();*/ // lỗi  chỉ sử dụng các phương thức của lớp Animal
        }
    }
}
