using System;
using System.Collections.Generic;
using BuildEngineMapReader.Geom;

namespace BuildEngineMapReader.Objects
{
    
    public class Map
    {
        public int Version { get; private set; }
        public Position StartPosition { get; private set; }
        public Sector[] Sectors { get; internal set; }
        public Wall[] Walls { get; internal set; }
        public Sprite[] Sprites { get; internal set; }
        public int StartSectorIndex { get; set; }
        public EditorMeta EditorMeta { get; internal set; }

        public Map(int version)
        {
            if (version != 7)
            {
                throw new ArgumentException("Currently only maps from the released version of Duke Nukem 3D are supported (map version 7)");
            }

            Version = version;
            StartPosition = new Position();
            Sectors = Array.Empty<Sector>(); // should be length <= 1024
            Walls = Array.Empty<Wall>(); // should be length <= 8192
            Sprites = Array.Empty<Sprite>(); // should be length <= 4096
            StartSectorIndex = -1;
            EditorMeta = new EditorMeta();
        }


        public override string ToString()
        {
            return $"Map version {Version} with {Sectors.Length} sectors, {Walls.Length} walls and {Sprites.Length} sprites. Start position: {StartPosition.X}, {StartPosition.Y}, {StartPosition.Z}, {StartPosition.Angle}";
        }
    }
}