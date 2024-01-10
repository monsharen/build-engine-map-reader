using BuildEngineMapReader.Geom;

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

        public Position Position { get; internal set; }
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

        public Sprite(Position position, StatData stat, int picNum, int shade, int palette, int clipDistance, Vector2 repeat, Vector2 offset, int currentSectorIndex, int currentStatus, int owner, Point3 velocity, int loTag, int hiTag, int extra)
        {
            Position = position;
            Stat = stat;
            PicNum = picNum;
            Shade = shade;
            Palette = palette;
            ClipDistance = clipDistance;
            Repeat = repeat;
            Offset = offset;
            CurrentSectorIndex = currentSectorIndex;
            CurrentStatus = currentStatus;
            Owner = owner;
            Velocity = velocity;
            LoTag = loTag;
            HiTag = hiTag;
            Extra = extra;
        }
    }
}