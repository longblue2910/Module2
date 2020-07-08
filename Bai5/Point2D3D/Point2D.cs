using System;
namespace Point2D3D
{
    public class Point2D
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public Point2D(){}
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float getY()
        {
            return y;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public float[] getXY()
        {
            float[] Array = {x , y};
            return Array;
        }
        public void setXY(float newX, float newY)
        {
            this.x = newX;
            this.y = newY;
        }
        public override String ToString()
        {
            return $"{x}, {y}";
        }
    }
}