using BuildEngineMapReader.Geom;

namespace BuildEngineMapReader.Objects
{
    
    public class Map
    {
        public int Version { get; }
        public Position StartPosition { get; }
        public Sector[] Sectors { get; }
        public Wall[] Walls { get; }
        public Sprite[] Sprites { get; }
        public int StartSectorIndex { get; }

        public Map(
            int version, 
            Position startPosition, 
            Sector[] sectors, 
            Wall[] walls, 
            Sprite[] sprites, 
            int startSectorIndex)
        {
            Version = version;
            StartPosition = startPosition;
            Sectors = sectors;
            Walls = walls;
            Sprites = sprites;
            StartSectorIndex = startSectorIndex;
        }
        
        public override string ToString()
        {
            return $"Map: Version: {Version}, StartPosition: {StartPosition}, StartSectorIndex: {StartSectorIndex}, Sectors: {Sectors.Length}, Walls: {Walls.Length}, Sprites: {Sprites.Length}";
        }
    }
}