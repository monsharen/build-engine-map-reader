using System.IO;
using BuildEngineMapReader.Geom;
using BuildEngineMapReader.Objects;

namespace BuildEngineMapReader
{
    public class MapFileReader
    {
        
        public Map ReadFile(string filePath)
        {
            var fileData = File.ReadAllBytes(filePath);
            return ParseFile(fileData);
        }
        private static Objects.Map ParseFile(byte[] fileData)
        {
            using (var memoryStream = new MemoryStream(fileData))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                var map = new Objects.Map(binaryReader.ReadInt32());
                map.StartPosition.X = binaryReader.ReadInt32();
                map.StartPosition.Y = binaryReader.ReadInt32();
                map.StartPosition.Z = binaryReader.ReadInt32();
                map.StartPosition.Angle = binaryReader.ReadInt16();
                map.StartSectorIndex = binaryReader.ReadInt16();

                var numSectors = binaryReader.ReadUInt16();
        
                map.Sectors = new Sector[numSectors];
                
                for (var i = 0; i < numSectors; i++) {
                    var sector = new Sector();
                    sector.FirstWallIndex = binaryReader.ReadInt16();
                    sector.NumWalls = binaryReader.ReadInt16();
                    sector.Ceiling.Z = binaryReader.ReadInt32();
                    sector.Floor.Z = binaryReader.ReadInt32();

                    var ceilingFlags = binaryReader.ReadInt16();
                    sector.Ceiling.Stat = FlagParser.ParseFloorCeilingFlags(ceilingFlags);

                    var floorFlags = binaryReader.ReadInt16();
                    sector.Floor.Stat = FlagParser.ParseFloorCeilingFlags(floorFlags);

                    sector.Ceiling.PicNum = binaryReader.ReadInt16();
                    sector.Ceiling.HeightNum = binaryReader.ReadInt16();
                    sector.Ceiling.Shade = binaryReader.ReadSByte();
                    sector.Ceiling.Palette = binaryReader.ReadByte();
                    sector.Ceiling.Panning = new Vector2(binaryReader.ReadByte(), binaryReader.ReadByte());

                    sector.Floor.PicNum = binaryReader.ReadInt16();
                    sector.Floor.HeightNum = binaryReader.ReadInt16();
                    sector.Floor.Shade = binaryReader.ReadSByte();
                    sector.Floor.Palette = binaryReader.ReadByte();
                    sector.Floor.Panning = new Vector2(binaryReader.ReadByte(), binaryReader.ReadByte());

                    sector.Visibility = binaryReader.ReadByte();

                    binaryReader.ReadByte(); // filler
                    
                    sector.LoTag = binaryReader.ReadInt16();
                    sector.HiTag = binaryReader.ReadInt16();
                    sector.Extra = binaryReader.ReadInt16();

                    map.Sectors[i] = sector;
                }
                
                var numWalls = binaryReader.ReadUInt16();
                map.Walls = new Wall[numWalls];
                
                for (var i = 0; i < numWalls; i++) {
                    var wall = new Wall(binaryReader.ReadInt32(), binaryReader.ReadInt32());
                    wall.Point2 = binaryReader.ReadInt16();
                    wall.NextWall = binaryReader.ReadInt16();
                    wall.NextSector = binaryReader.ReadInt16();

                    var wallFlags = binaryReader.ReadInt16();
                    
                    wall.Stat = FlagParser.ParseWallFlags(wallFlags);

                    wall.PicNum = binaryReader.ReadInt16();
                    wall.OverPicNum = binaryReader.ReadInt16();
                    wall.Shade = binaryReader.ReadByte();
                    wall.Palette = binaryReader.ReadByte();
                    wall.Repeat = new Point2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    wall.Panning = new Point2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    wall.LoTag = binaryReader.ReadInt16();
                    wall.HiTag = binaryReader.ReadInt16();
                    wall.Extra = binaryReader.ReadInt16();
                    
                    map.Walls[i] = wall;
                }
                
                
                var numSprites = binaryReader.ReadUInt16();
                map.Sprites = new Sprite[numSprites];

                for (var i = 0; i < numSprites; i++) {
                    var sprite = new Sprite(
                        binaryReader.ReadInt32(),
                        binaryReader.ReadInt32(),
                        binaryReader.ReadInt32()
                    );

                    var spriteFlags = binaryReader.ReadInt16();
                    sprite.Stat = FlagParser.ParseSpriteFlags(spriteFlags);

                    sprite.PicNum = binaryReader.ReadInt16();
                    sprite.Shade = binaryReader.ReadSByte(); // Or should it be ReadByte?
                    sprite.Palette = binaryReader.ReadByte(); // Or should it be ReadSByte?
                    sprite.ClipDistance = binaryReader.ReadByte(); // Or should it be ReadSByte?
                    
                    binaryReader.ReadByte(); // padding

                    sprite.Repeat = new Vector2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    sprite.Offset = new Vector2(binaryReader.ReadSByte(), binaryReader.ReadSByte());
                    sprite.CurrentSectorIndex = binaryReader.ReadInt16();
                    sprite.CurrentStatus = binaryReader.ReadInt16();
                    sprite.Angle = binaryReader.ReadInt16();
                    sprite.Owner = binaryReader.ReadInt16();

                    sprite.Velocity = new Point3(
                        binaryReader.ReadInt16(),
                        binaryReader.ReadInt16(),
                        binaryReader.ReadInt16()
                    );

                    sprite.LoTag = binaryReader.ReadInt16();
                    sprite.HiTag = binaryReader.ReadInt16();
                    sprite.Extra = binaryReader.ReadInt16();

                    map.Sprites[i] = sprite;
                }
                
                return map;
            }
        }
    }
}