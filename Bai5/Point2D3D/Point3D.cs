using System;
namespace Point2D3D
{
    class Point3D : Point2D
    {
        public float z = 0.0f;
        public Point3D(){}
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float getZ()
        {
            return z;
        }
        public void setZ(float z)
        {
            this.z = z;
        }
        public float[] getXYZ()
        {
            float[] Array = {x , y, z};
            return Array;
        }
        public void setXYZ(float newX, float newY, float newZ)
        {
            this.x = newX;
            this.y = newY;
            this.z = newZ;
        }
        public override String ToString() 
        {
            return $"{x}, {y}, {z}";
        }
    }
}