using System;

namespace CircleCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle Tron1 = new Circle();
            // Console.WriteLine(Tron1);

            // Circle Tron2 = new Circle(13, "Red");
            // Console.WriteLine(Tron2);

            Cylinder cylinder = new Cylinder();
            Console.WriteLine(cylinder);
        }
    }
    public class Circle{
        private double radius = 1.0;

        private string color = "Blue";
        public Circle(){}
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public String GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
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
            return "A Circle with color of"
            +GetColor()
            + "and radius = " +GetRadius() 
            + " ,area : " + GetArea()
            + " ,perimeter : " + GetPerimeter();
        }
    }
    public class Cylinder : Circle
    {
        private double height = 2.0;
        public Cylinder(){}
        public Cylinder(double height)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double getAreAround()
        {
            return 2 * Math.PI * base.GetRadius() * height;
        }
        public double getVolume()
        {
            return Math.PI * (base.GetRadius() * 2) * height;
        }
        public override String ToString()
        {
            return "A Cylinder width height : " 
            +GetHeight() 
            +",which is a subclass of" + " radius = " +base.GetRadius()+ " ,color : " + base.GetColor()
            + " and AreaAround : "
            +getAreAround() 
            + ", Volume : " 
            +getVolume();
        }

    }
}
