namespace BuildEngineMapReader.Objects
{
    public class Sector
    {
        public int FirstWallIndex { get; set; }
        public int NumWalls { get; set; }
        public Ceiling Ceiling { get; private set; }
        public Floor Floor { get; private set; }
        public int Visibility { get; set; }
        public int LoTag { get; set; }
        public int HiTag { get; set; }
        public int Extra { get; set; }

        public Sector(int firstWallIndex, int numWalls, Ceiling ceiling, Floor floor, int visibility, int loTag, int hiTag, int extra)
        {
            FirstWallIndex = firstWallIndex;
            NumWalls = numWalls;
            Ceiling = ceiling;
            Floor = floor;
            Visibility = visibility;
            LoTag = loTag;
            HiTag = hiTag;
            Extra = extra;
        }
    }
}