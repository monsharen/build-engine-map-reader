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
            return Parse(fileData);
        }
        public static Map Parse(byte[] fileData)
        {
            using (var memoryStream = new MemoryStream(fileData))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                var version = binaryReader.ReadInt32();
                var startPosition = new Position(
                    binaryReader.ReadInt32(), 
                    binaryReader.ReadInt32(), 
                    binaryReader.ReadInt32(), 
                    binaryReader.ReadInt16());
                var startSectorIndex = binaryReader.ReadInt16();

                var numSectors = binaryReader.ReadUInt16();
                
                var sectors = new Sector[numSectors];
                
                for (var i = 0; i < numSectors; i++) {
                    
                    var sectorFirstWallIndex = binaryReader.ReadInt16();
                    var sectorNumWalls = binaryReader.ReadInt16();
                    
                    var ceilingZ = binaryReader.ReadInt32();
                    var floorZ = binaryReader.ReadInt32();

                    var ceilingFlags = binaryReader.ReadInt16();
                    var ceilingStatData = FlagParser.ParseFloorCeilingFlags(ceilingFlags);

                    var floorFlags = binaryReader.ReadInt16();
                    var floorStatData = FlagParser.ParseFloorCeilingFlags(floorFlags);

                    var ceilingPicNum = binaryReader.ReadInt16();
                    var ceilingHeightNum = binaryReader.ReadInt16();
                    var ceilingShade = binaryReader.ReadSByte();
                    var ceilingPalette = binaryReader.ReadByte();
                    var ceilingPanning = new Vector2(binaryReader.ReadByte(), binaryReader.ReadByte());

                    var ceiling = new Ceiling(ceilingZ, 
                        ceilingStatData, 
                        ceilingPicNum, 
                        ceilingHeightNum, 
                        ceilingShade, 
                        ceilingPalette, 
                        ceilingPanning);

                    var floorPicNum = binaryReader.ReadInt16();
                    var floorHeightNum = binaryReader.ReadInt16();
                    var floorShade = binaryReader.ReadSByte();
                    var floorPalette = binaryReader.ReadByte();
                    var floorPanning = new Vector2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    var floor = new Floor(floorZ, 
                        floorStatData, 
                        floorPicNum, 
                        floorHeightNum, 
                        floorShade, 
                        floorPalette, 
                        floorPanning);
                    
                    var sectorVisibility = binaryReader.ReadByte();

                    binaryReader.ReadByte(); // filler
                    
                    var sectorLoTag = binaryReader.ReadInt16();
                    var sectorHiTag = binaryReader.ReadInt16();
                    var sectorExtra = binaryReader.ReadInt16();

                    var sector = new Sector(sectorFirstWallIndex, 
                        sectorNumWalls, 
                        ceiling, 
                        floor, 
                        sectorVisibility, 
                        sectorLoTag, 
                        sectorHiTag, 
                        sectorExtra);
                    sectors[i] = sector;
                }
                
                var numWalls = binaryReader.ReadUInt16();
                var walls = new Wall[numWalls];
                
                for (var i = 0; i < numWalls; i++)
                {
                    var x = binaryReader.ReadInt32();
                    var y = binaryReader.ReadInt32();
                    var nextWallPoint2 = binaryReader.ReadInt16();
                    var wallNextWall = binaryReader.ReadInt16();
                    var wallNextSector = binaryReader.ReadInt16();

                    var wallFlags = binaryReader.ReadInt16();
                    var wallStat = FlagParser.ParseWallFlags(wallFlags);

                    var wallPicNum = binaryReader.ReadInt16();
                    var wallOverPicNum = binaryReader.ReadInt16();
                    var wallShade = binaryReader.ReadByte();
                    var wallPalette = binaryReader.ReadByte();
                    var wallRepeat = new Point2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    var wallPanning = new Point2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    var wallLoTag = binaryReader.ReadInt16();
                    var wallHiTag = binaryReader.ReadInt16();
                    var wallExtra = binaryReader.ReadInt16();
                    
                    var wall = new Wall(
                        x,
                        y,
                        nextWallPoint2,
                        wallNextWall,
                        wallNextSector,
                        wallStat,
                        wallPicNum,
                        wallOverPicNum,
                        wallShade,
                        wallPalette,
                        wallRepeat,
                        wallPanning,
                        wallLoTag,
                        wallHiTag,
                        wallExtra
                    );
                    
                    walls[i] = wall;
                }
                
                var numSprites = binaryReader.ReadUInt16();
                var sprites = new Sprite[numSprites];

                for (var i = 0; i < numSprites; i++)
                {
                    var x = binaryReader.ReadInt32();
                    var y = binaryReader.ReadInt32();
                    var z = binaryReader.ReadInt32();
                    
                    var spriteFlags = binaryReader.ReadInt16();
                    var spriteStat = FlagParser.ParseSpriteFlags(spriteFlags);

                    var spritePicNum = binaryReader.ReadInt16();
                    var spriteShade = binaryReader.ReadSByte(); // Or should it be ReadByte?
                    var spritePalette = binaryReader.ReadByte(); // Or should it be ReadSByte?
                    var spriteClipDistance = binaryReader.ReadByte(); // Or should it be ReadSByte?
                    
                    binaryReader.ReadByte(); // padding

                    var spriteRepeat = new Vector2(binaryReader.ReadByte(), binaryReader.ReadByte());
                    var spriteOffset = new Vector2(binaryReader.ReadSByte(), binaryReader.ReadSByte());
                    var spriteCurrentSectorIndex = binaryReader.ReadInt16();
                    var spriteCurrentStatus = binaryReader.ReadInt16();
                    var spriteAngle = binaryReader.ReadInt16();
                    var spriteOwner = binaryReader.ReadInt16();

                    var position = new Position(
                        x,
                        y,
                        z, spriteAngle);
                    
                    var spriteVelocity = new Point3(
                        binaryReader.ReadInt16(),
                        binaryReader.ReadInt16(),
                        binaryReader.ReadInt16()
                    );

                    var spriteLoTag = binaryReader.ReadInt16();
                    var spriteHiTag = binaryReader.ReadInt16();
                    var spriteExtra = binaryReader.ReadInt16();
                    
                    var sprite = new Sprite(
                        position,
                        spriteStat,
                        spritePicNum,
                        spriteShade,
                        spritePalette,
                        spriteClipDistance,
                        spriteRepeat,
                        spriteOffset,
                        spriteCurrentSectorIndex,
                        spriteCurrentStatus,
                        spriteOwner,
                        spriteVelocity,
                        spriteLoTag,
                        spriteHiTag,
                        spriteExtra
                    );

                    sprites[i] = sprite;
                }
                
                return new Map(version, startPosition, sectors, walls, sprites, startSectorIndex);
            }
        }
    }
}