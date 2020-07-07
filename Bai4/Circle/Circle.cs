using System;

namespace Circle
{
    public class Circle
    {
        private double radius = 1.0;
        private string color = "red";
        
        public Circle(){}
        public Circle(double _radius, string _color){
            this.radius = _radius;
            this.color = _color;
        }
        public double GetRadius(){
            return this.radius;
        }
        public void SetRadius(double _radius){
            this.radius = _radius;
        }
        public string GetColor(){
            return this.color;
        }
        public void SetColor(string _color){
            this.color = _color;
        }
    }
}