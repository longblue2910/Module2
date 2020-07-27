using System;
namespace MoveablePoint
{
    class MoveablePoint : Point2D
    {
        public float xSpeed = 0.0f;
        public float ySpeed = 0.0f;
        public MoveablePoint() { }
        public MoveablePoint(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public float getxSpeed()
        {
            return xSpeed;
        }
        public void setxSpeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float getySpeed()
        {
            return ySpeed;
        }
        public void setySpeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        public void setXY1(float x, float y)
        {
            this.x = x;
            this.y= y;
        }
        public float[] getSpeed()
        {
            float[] array = {xSpeed, ySpeed};
            return array;
        }
        public override String ToString()
        {
            return $"{xSpeed}, {ySpeed}" ;
        } 
        public MoveablePoint Move()
        {
           x += xSpeed;
           y += ySpeed;
           return this;
        }

    }
}