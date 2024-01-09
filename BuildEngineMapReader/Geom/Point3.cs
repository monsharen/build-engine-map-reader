namespace Map.Geom
{
    public class Point3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3(float x = 0, float y = 0, float z = 0)
        {
            Set(x, y, z);
        }

        public Point3 Set(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
            return this;
        }

        public Point3 Translate(float deltaX, float deltaY, float deltaZ)
        {
            X += deltaX;
            Y += deltaY;
            Z += deltaZ;
            return this;
        }

        public Point3 Clone()
        {
            return new Point3(X, Y, Z);
        }

        public Point3 CopyFrom(Point3 point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
            return this;
        }
    }
}