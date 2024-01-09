using Map.Geom;

namespace BuildEngineMapReader.Objects
{
    public class Sprite
    {
        public enum Orientation
        {
            Face = 0,
            Wall = 1,
            Floor = 2
        }

        public Point3 Position { get; internal set; }
        public float Angle { get; internal set; }
        public StatData Stat { get; internal set; }
        public int PicNum { get; set; }
        public int Shade { get; set; }
        public int Palette { get; set; }
        public int ClipDistance { get; set; }
        public Vector2 Repeat { get; set; }
        public Vector2 Offset { get; set; }
        public int CurrentSectorIndex { get; set; }
        public int CurrentStatus { get; set; }
        public int Owner { get; set; }
        public Point3 Velocity { get; set; }
        public int LoTag { get; set; }
        public int HiTag { get; set; }
        public int Extra { get; set; }

        public Sprite(float x = 0, float y = 0, float z = 0, float angle = 0)
        {
            Position = new Point3(x, y, z);
            Angle = angle;
            Stat = new StatData();
            Repeat = new Vector2();
            Offset = new Vector2();
            Velocity = new Point3();
        }
        // GetProps method can be implemented as needed
    }
}