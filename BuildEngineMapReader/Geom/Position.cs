namespace BuildEngineMapReader.Geom
{
    public class Position : Point3
    {
        private int _angle;

        public Position()
        {
            Angle = 0;
        }

        public int Angle
        {
            get => _angle;
            set => _angle = ((value % 2047) + 2047) % 2047;
        }
    }
}