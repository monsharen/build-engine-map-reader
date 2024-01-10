namespace BuildEngineMapReader.Geom
{
    public class Point3
    {
        public float X { get; }
        public float Y { get; }
        public float Z { get; }

        public Point3(float x = 0, float y = 0, float z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}