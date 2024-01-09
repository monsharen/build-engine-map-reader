using BuildEngineMapReader.Geom;

namespace BuildEngineMapReader.Objects
{
    public class Wall : Point2
    {
        public int Point2 { get; set; }
        public int NextWall { get; set; }
        public int NextSector { get; set; }
        public StatData Stat { get; internal set; }
        public int PicNum { get; set; }
        public int OverPicNum { get; set; }
        public int Shade { get; set; }
        public int Palette { get; set; }
        public Point2 Repeat { get; set; }
        public Point2 Panning { get; set; }
        public int LoTag { get; set; }
        public int HiTag { get; set; }
        public int Extra { get; set; }

        public Wall(float x = 0, float y = 0) : base(x, y)
        {
            NextWall = -1;
            NextSector = -1;
            Stat = new StatData();
            Repeat = new Point2();
            Panning = new Point2();
            Extra = -1;
        }

        // Implement Point2 class
        // Implement the GetProps method as needed
    }
}