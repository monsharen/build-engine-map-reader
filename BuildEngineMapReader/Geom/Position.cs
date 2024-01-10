namespace BuildEngineMapReader.Geom
{
    public class Position : Point3
    {
        private int _angle;
        
        public Position(float x, float y, float z, int angle) : base(x, y, z)
        {
            Angle = angle;
        }

        public int Angle
        {
            get => _angle;
            private set => _angle = ((value % 2047) + 2047) % 2047;
        }
    }
}