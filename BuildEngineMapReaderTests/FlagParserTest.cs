using BuildEngineMapReader;
using BuildEngineMapReader.Objects;
using NUnit.Framework;

namespace BuildEngineMapReaderTests
{
    public class FlagParserTest 
    {
        
        [Test]
        public void ShouldParseWallFlags()
        {
            var wallFlags = FlagParser.ParseWallFlags(0);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(1);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(121);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(true, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(true, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(128);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(132);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(true, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(134);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(true, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(true, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(144);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(152);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(true, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(153);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(true, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(16);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(2);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(true, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(209);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(211);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(true, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(217);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(true, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(4);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(true, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(64);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(705);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(true, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(721);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(true, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(729);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(true, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(true, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(true, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(8);
            Assert.AreEqual(false, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(false, wallFlags.AlignPictureBottom);
            Assert.AreEqual(true, wallFlags.XFlip);
            Assert.AreEqual(false, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(false, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
            
            wallFlags = FlagParser.ParseWallFlags(85);
            Assert.AreEqual(true, wallFlags.BlockClipMove);
            Assert.AreEqual(false, wallFlags.BottomsInvisibleSwapped);
            Assert.AreEqual(true, wallFlags.AlignPictureBottom);
            Assert.AreEqual(false, wallFlags.XFlip);
            Assert.AreEqual(true, wallFlags.Mask);
            Assert.AreEqual(false, wallFlags.OneWay);
            Assert.AreEqual(true, wallFlags.BlockHitScan);
            Assert.AreEqual(false, wallFlags.Translucent);
            Assert.AreEqual(false, wallFlags.YFlip);
            Assert.AreEqual(false, wallFlags.TranslucentReverse);
        }

        [Test]
        public void ShouldParseFloorCeilingFlags()
        {
            /*
             * Floor
             */
            var floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(2);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(false, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(16);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(20);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(22);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(56);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(true, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(84);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(true, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(112);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(true, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(116);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(true, floorCeilingFlags.AlignTextureToFirstWall);
            /*
             * Ceiling
             */
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(48);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(49);
            Assert.AreEqual(true, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(50);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(51);
            Assert.AreEqual(true, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
        }

        [Test]
        public void ShouldParseSpriteFlags()
        {
            var spriteFlags = FlagParser.ParseSpriteFlags(0);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(1);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(12);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(true, spriteFlags.XFlip);
            Assert.AreEqual(true, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(17);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(2);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(true, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(208);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(true, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(256);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(true, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(257);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(true, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(277);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(true, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(true, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(289); 
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Floor, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(true, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
                
            spriteFlags = FlagParser.ParseSpriteFlags(32);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Floor, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(33);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Floor, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            
            spriteFlags = FlagParser.ParseSpriteFlags(37);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(true, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Floor, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            
            spriteFlags = FlagParser.ParseSpriteFlags(45);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(true, spriteFlags.XFlip);
            Assert.AreEqual(true, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Floor, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            
            spriteFlags = FlagParser.ParseSpriteFlags(514);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(true, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(true, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(515);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(true, spriteFlags.Translucent); 
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(false, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(true, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            
            spriteFlags = FlagParser.ParseSpriteFlags(594);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(true, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(true, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(64);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(65);  
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Face, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            

            spriteFlags = FlagParser.ParseSpriteFlags(80);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(81);
            Assert.AreEqual(true, spriteFlags.BlockClipMove);
            Assert.AreEqual(false, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
            
            spriteFlags = FlagParser.ParseSpriteFlags(82);
            Assert.AreEqual(false, spriteFlags.BlockClipMove);
            Assert.AreEqual(true, spriteFlags.Translucent);
            Assert.AreEqual(false, spriteFlags.XFlip);
            Assert.AreEqual(false, spriteFlags.YFlip);
            Assert.AreEqual(Sprite.Orientation.Wall, spriteFlags.Orientation);
            Assert.AreEqual(true, spriteFlags.OneSided);
            Assert.AreEqual(false, spriteFlags.RealCentered);
            Assert.AreEqual(false, spriteFlags.BlockHitScan);
            Assert.AreEqual(false, spriteFlags.TranslucentReverse);
            Assert.AreEqual(false, spriteFlags.Invisible);
        }
    }
}