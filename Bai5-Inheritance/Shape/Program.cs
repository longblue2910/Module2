using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Shape shape = new Shape();
            //    Console.WriteLine(shape);
            //    shape = new Shape("red" , false);
            //    Console.WriteLine(shape);

            // Cirle cirle = new Cirle();
            // Console.WriteLine(cirle);

            // cirle = new Cirle(3.5);
            // Console.WriteLine(cirle);

            // cirle = new Cirle(3.5, "indigo", false);
            // Console.WriteLine(cirle);

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);

            // rectangle = new Rectangle(2.5, 3.8, "orange", true);

            // Console.WriteLine(rectangle);


        }
    }
    public class Shape
    {
        private String color = "green";
        private bool filled = true;
        public Shape() { }
        public Shape(String color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public String GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public bool isFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public override String ToString()
        {
            return "A Shape with color of "
            + GetColor() + "and" + (isFilled() ? "filled" : "not filled");
        }
    }
    public class Cirle : Shape
    {
        private double radius = 1.0;
        public Cirle() { }
        public Cirle(double radius)
        {
            this.radius = radius;
        }
        public Cirle(double radius, String color, bool filled)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override String ToString()
        {
            return "A Circle with radius ="
            + GetRadius()
            + ",which is a subclass of "
            + base.ToString();
        }
    }
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle() { }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetLength()
        {
            return length;
        }
        public virtual void SetLength(double length)
        {
            this.length = length;
        }
        public double GetAre()
        {
            return width * this.length;
        }
        public double GetPerimeter()
        {
            return 2 * (width + this.length);
        }
        public override String ToString()
        {
            return "A Rectangle with width = "
            + GetWidth()
            + "and length = "
            + GetLength()
            + ", which is a subclass of"
            + base.ToString();
        }
    }
    
}
