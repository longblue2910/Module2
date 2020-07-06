using System;

namespace HCN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width :");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height :");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());

        }
    }
    public class Rectangle
    {
        double height, width;
        public Rectangle()
        {
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }
        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }
        public string Display()
        {
            return "Rectangle {" + "width=" + width + ", height=" + height + "}";
        }
    }
}
