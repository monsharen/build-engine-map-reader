using BuildEngineMapReader.Geom;

namespace BuildEngineMapReader.Objects
{
    public class Wall : Point2
    {
        public short NextWallPoint2 { get; }
        public int NextWall { get; }
        public int NextSector { get; }
        public StatData Stat { get; }
        public int PicNum { get; }
        public int OverPicNum { get; }
        public int Shade { get; }
        public int Palette { get; }
        public Point2 Repeat { get; }
        public Point2 Panning { get; }
        public int LoTag { get; }
        public int HiTag { get; }
        public int Extra { get; }

        public Wall(float x, float y, short nextWallPoint2, int nextWall, int nextSector, StatData stat, int picNum, int overPicNum, int shade, int palette, Point2 repeat, Point2 panning, int loTag, int hiTag, int extra) : base(x, y)
        {
            NextWallPoint2 = nextWallPoint2;
            NextWall = nextWall;
            NextSector = nextSector;
            Stat = stat;
            PicNum = picNum;
            OverPicNum = overPicNum;
            Shade = shade;
            Palette = palette;
            Repeat = repeat;
            Panning = panning;
            LoTag = loTag;
            HiTag = hiTag;
            Extra = extra;
        }
    }
}