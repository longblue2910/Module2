using System;

namespace Triangle
{
    public class Triangle
    {
       public double side1 = 1.0;
       public double side2 = 1.0;
       public double side3 = 1.0;

       public Triangle(double side1, double side2, double side3)
       {
           this.side1 = side1;
           this.side2 = side2;
           this.side3 = side3;
       }
       public double Side1 {get => side1; set => side1 = value;}
       public double Side2 {get => side2; set => side2 = value;}
       public double Side3 {get => side3; set => side3 = value;}
       
       public double GetPerimeter()
       {
           double p = side1 + side2 + side3;
           return p;
       }
       public double getArea()
       {
           double p2 = (side1 + side2 + side3)/2;
           double area = Math.Sqrt(p2 * ((p2 - side1) * (p2 - side2) * (p2 - side3)));
           return area;
       }
       public override String ToString()
       {
           return $"A Triangle have side 1 :{side1}, side 2: {side2}, side3, {side3}";
       }
    }
}