using System;
using System.Collections.Generic;
using System.IO;
using BuildEngineMapReader.Objects;
using Map.Geom;

namespace BuildEngineMapReader
{
    public class MapFileReader
    {

        public static StatData ParseFloorCeilingFlags(int input)
        {
            var dictionary = ParseBits(input, FlagConstants.FloorCeilingFlagsMap);

            var statData = new StatData();
            statData.Parallaxing = (bool)dictionary["parallaxing"];
            statData.Sloped = (bool)dictionary["sloped"];
            statData.SwapXY = (bool) dictionary["swapXY"];
            statData.DoubleSmooshiness = (bool) dictionary["doubleSmooshiness"];
            statData.XFlip = (bool)dictionary["xFlip"];
            statData.YFlip = (bool)dictionary["yFlip"];
            statData.AlignTextureToFirstWall = (bool)dictionary["alignTextureToFirstWall"];
            return statData;
        }
        
        public static StatData ParseWallFlags(int input)
        {
            var dictionary = ParseBits(input, FlagConstants.WallFlagsMap);

            var statData = new StatData();
            statData.BlockClipMove = (bool)dictionary["blockClipMove"];
            statData.BottomsInvisibleSwapped = (bool)dictionary["bottomsInvisibleSwapped"];
            statData.AlignPictureBottom = (bool)dictionary["alignPictureBottom"];
            statData.XFlip = (bool)dictionary["xFlip"];
            statData.Mask = (bool)dictionary["mask"];
            statData.OneWay = (bool)dictionary["oneWay"];
            statData.BlockHitScan = (bool)dictionary["blockHitScan"];
            statData.Translucent = (bool)dictionary["translucent"];
            statData.YFlip = (bool)dictionary["yFlip"];
            statData.TranslucentReverse = (bool)dictionary["translucentReverse"];
            return statData;
        }

        public static StatData ParseSpriteFlags(int input)
        {
            var dictionary = ParseBits(input, FlagConstants.SpriteFlagsMap);
            var statData = new StatData();
            statData.BlockClipMove = (bool)dictionary["blockClipMove"];
            statData.Translucent = (bool)dictionary["translucent"];
            statData.XFlip = (bool)dictionary["xFlip"];
            statData.YFlip = (bool)dictionary["yFlip"];
            statData.Orientation = (Sprite.Orientation)dictionary["orientation"];
            statData.OneSided = (bool)dictionary["oneSided"];
            statData.RealCentered = (bool)dictionary["realCentered"];
            statData.BlockHitScan = (bool)dictionary["blockHitScan"];
            statData.TranslucentReverse = (bool)dictionary["translucentReverse"];
            statData.Invisible = (bool)dictionary["invisible"];
            return statData;
        }
        
        private static Dictionary<string, object> ParseBits(int input, Flag[] flagList)
        {
            if (flagList == null)
            {
                throw new ArgumentNullException(nameof(flagList), "A flag list must be provided");
            }

            var output = new Dictionary<string, object>();
            foreach (var item in flagList)
            {
                if (string.IsNullOrEmpty(item.Name) || item.Index < 0)
                {
                    throw new ArgumentException("A name and index must be provided on each flag list item");
                }

                int mask = (1 << (item.Size ?? 1)) - 1;
                int value = (input >> item.Index) & mask;

                if (!item.Size.HasValue || item.Size <= 1)
                {
                    output[item.Name] = value != 0;
                }
                else
                {
                    output[item.Name] = value;
                }
            }

            return output;
        }
        
        private static Objects.Map ParseFile(byte[] fileData)
        {
            var memoryStream = new MemoryStream(fileData);
            using (var view = new BinaryReader(memoryStream))
            {
                var map = new Objects.Map(view.ReadInt32());
                map.StartPosition.X = view.ReadInt32();
                map.StartPosition.Y = view.ReadInt32();
                map.StartPosition.Z = view.ReadInt32();
                map.StartPosition.Angle = view.ReadInt16();
                map.StartSectorIndex = view.ReadInt16();

                var numSectors = view.ReadUInt16();
        
                map.Sectors = new Sector[numSectors];
                
                for (var i = 0; i < numSectors; i++) {
                    var sector = new Sector();
                    sector.FirstWallIndex = view.ReadInt16();
                    sector.NumWalls = view.ReadInt16();
                    sector.Ceiling.Z = view.ReadInt32();
                    sector.Floor.Z = view.ReadInt32();

                    var ceilingFlags = view.ReadInt16();
                    sector.Ceiling.Stat = ParseFloorCeilingFlags(ceilingFlags);

                    var floorFlags = view.ReadInt16();
                    sector.Floor.Stat = ParseFloorCeilingFlags(floorFlags);

                    sector.Ceiling.PicNum = view.ReadInt16();
                    sector.Ceiling.HeightNum = view.ReadInt16();
                    sector.Ceiling.Shade = view.ReadSByte();
                    sector.Ceiling.Palette = view.ReadByte();
                    sector.Ceiling.Panning = new Vector2(view.ReadByte(), view.ReadByte());

                    sector.Floor.PicNum = view.ReadInt16();
                    sector.Floor.HeightNum = view.ReadInt16();
                    sector.Floor.Shade = view.ReadSByte();
                    sector.Floor.Palette = view.ReadByte();
                    sector.Floor.Panning = new Vector2(view.ReadByte(), view.ReadByte());

                    sector.Visibility = view.ReadByte();

                    var filler = view.ReadByte();
                    
                    sector.LoTag = view.ReadInt16();
                    sector.HiTag = view.ReadInt16();
                    sector.Extra = view.ReadInt16();

                    map.Sectors[i] = sector;
                }
                
                var numWalls = view.ReadUInt16();
                map.Walls = new Wall[numWalls];
                
                Logger.Log("numWalls: " + numWalls);
                for (var i = 0; i < numWalls; i++) {
                    var wall = new Wall(view.ReadInt32(), view.ReadInt32());
                    wall.Point2 = view.ReadInt16();
                    wall.NextWall = view.ReadInt16();
                    wall.NextSector = view.ReadInt16();

                    var wallFlags = view.ReadInt16();
                    wall.Stat = ParseWallFlags(wallFlags);

                    wall.PicNum = view.ReadInt16();
                    wall.OverPicNum = view.ReadInt16();
                    wall.Shade = view.ReadByte();
                    wall.Palette = view.ReadByte();
                    wall.Repeat.Set(view.ReadByte(), view.ReadByte());
                    wall.Panning.Set(view.ReadByte(), view.ReadByte());
                    wall.LoTag = view.ReadInt16();
                    wall.HiTag = view.ReadInt16();
                    wall.Extra = view.ReadInt16();
                    
                    map.Walls[i] = wall;
                }
                
                
                var numSprites = view.ReadUInt16();
                map.Sprites = new Sprite[numSprites];
                for (var i = 0; i < numSprites; i++) {
                    var sprite = new Sprite(
                        view.ReadInt32(),
                        view.ReadInt32(),
                        view.ReadInt32()
                    );

                    var spriteFlags = view.ReadInt16();
                    sprite.Stat = ParseSpriteFlags(spriteFlags);

                    sprite.PicNum = view.ReadInt16();
                    sprite.Shade = view.ReadSByte(); // Or should it be ReadByte?
                    sprite.Palette = view.ReadByte(); // Or should it be ReadSByte?
                    sprite.ClipDistance = view.ReadByte(); // Or should it be ReadSByte?
                    
                    view.ReadByte(); // padding

                    sprite.Repeat = new Vector2(view.ReadByte(), view.ReadByte());
                    sprite.Offset = new Vector2(view.ReadSByte(), view.ReadSByte());
                    sprite.CurrentSectorIndex = view.ReadInt16();
                    sprite.CurrentStatus = view.ReadInt16();
                    sprite.Angle = view.ReadInt16();
                    sprite.Owner = view.ReadInt16();

                    sprite.Velocity = new Point3(
                        view.ReadInt16(),
                        view.ReadInt16(),
                        view.ReadInt16()
                    );

                    sprite.LoTag = view.ReadInt16();
                    sprite.HiTag = view.ReadInt16();
                    sprite.Extra = view.ReadInt16();

                    map.Sprites[i] = sprite;
                }
                
                return map;
            }
        }

        public Objects.Map ReadFile(string filePath)
        {
            var fileData = File.ReadAllBytes(filePath);
            return ParseFile(fileData);
        }
    }
}