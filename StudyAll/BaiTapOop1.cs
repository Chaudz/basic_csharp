using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyAll
{

    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
    class Circle: Shape
    {
        private double radius;

        public Circle() { }
        public Circle(double radius) {
            this.radius = radius;
        }
        public override double CalculateArea() {
            return 2 * radius * Math.PI;
        }
        public override double CalculatePerimeter() {
            return radius * radius * Math.PI;
        }
    }
    class Rectangle : Shape
    {
        private double height;
        private double weight;

        public Rectangle() { }
        public Rectangle(double height, double weight){
            this.height = height;
            this.weight = weight;
        }
        public override  double CalculateArea()
        {
            return height * weight;
        }
        public override  double CalculatePerimeter()
        {
            return (height + weight) / 2;
        }
    }
    internal class BaiTapOop1
    {
       static void Main(string[] args)
        {
            var hcn1 = new Rectangle(4.5,5.3);
            Console.WriteLine(hcn1.CalculateArea());
            Console.WriteLine(hcn1.CalculatePerimeter());
            var ht1 = new Circle(5);
            Console.WriteLine(ht1.CalculateArea());
            Console.WriteLine(ht1.CalculatePerimeter());
        }
    }

}
