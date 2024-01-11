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
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(1);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(121);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(true));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(true));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(128);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(132);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(true));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(134);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(true));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(true));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(144);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(152);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(true));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(153);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(true));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(16);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(2);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(true));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(209);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(211);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(true));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(217);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(true));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(4);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(true));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(64);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(705);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(true));

            wallFlags = FlagParser.ParseWallFlags(721);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(true));

            wallFlags = FlagParser.ParseWallFlags(729);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(true));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(true));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(true));

            wallFlags = FlagParser.ParseWallFlags(8);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(false));
            Assert.That(wallFlags.XFlip, Is.EqualTo(true));
            Assert.That(wallFlags.Mask, Is.EqualTo(false));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));

            wallFlags = FlagParser.ParseWallFlags(85);
            Assert.That(wallFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(wallFlags.BottomsInvisibleSwapped, Is.EqualTo(false));
            Assert.That(wallFlags.AlignPictureBottom, Is.EqualTo(true));
            Assert.That(wallFlags.XFlip, Is.EqualTo(false));
            Assert.That(wallFlags.Mask, Is.EqualTo(true));
            Assert.That(wallFlags.OneWay, Is.EqualTo(false));
            Assert.That(wallFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(wallFlags.Translucent, Is.EqualTo(false));
            Assert.That(wallFlags.YFlip, Is.EqualTo(false));
            Assert.That(wallFlags.TranslucentReverse, Is.EqualTo(false));
        }

        [Test]
        public void ShouldParseFloorCeilingFlags()
        {
            /*
             * Floor
             */
            var floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(2);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(16);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(20);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(22);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(56);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(84);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(true));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(112);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(true));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(116);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(true));
            /*
             * Ceiling
             */
            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(48);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(49);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(50);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));

            floorCeilingFlags = FlagParser.ParseFloorCeilingFlags(51);
            Assert.That(floorCeilingFlags.Parallaxing, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.Sloped, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.SwapXY, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.DoubleSmooshiness, Is.EqualTo(false));
            Assert.That(floorCeilingFlags.XFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.YFlip, Is.EqualTo(true));
            Assert.That(floorCeilingFlags.AlignTextureToFirstWall, Is.EqualTo(false));
        }

        [Test]
        public void ShouldParseSpriteFlags()
        {
            var spriteFlags = FlagParser.ParseSpriteFlags(0);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(1);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(12);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(true));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(true));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(17);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(2);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(true));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(208);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(true));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(256);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(257);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(277);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(true));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(289);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Floor));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(true));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));


            spriteFlags = FlagParser.ParseSpriteFlags(32);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Floor));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(33);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Floor));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));


            spriteFlags = FlagParser.ParseSpriteFlags(37);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(true));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Floor));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));


            spriteFlags = FlagParser.ParseSpriteFlags(45);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(true));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(true));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Floor));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));


            spriteFlags = FlagParser.ParseSpriteFlags(514);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(true));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(true));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(515);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(true));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(false));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(true));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));


            spriteFlags = FlagParser.ParseSpriteFlags(594);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(true));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(true));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(64);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(65);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Face));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));


            spriteFlags = FlagParser.ParseSpriteFlags(80);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(81);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(true));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(false));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));

            spriteFlags = FlagParser.ParseSpriteFlags(82);
            Assert.That(spriteFlags.BlockClipMove, Is.EqualTo(false));
            Assert.That(spriteFlags.Translucent, Is.EqualTo(true));
            Assert.That(spriteFlags.XFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.YFlip, Is.EqualTo(false));
            Assert.That(spriteFlags.Orientation, Is.EqualTo(Sprite.Orientation.Wall));
            Assert.That(spriteFlags.OneSided, Is.EqualTo(true));
            Assert.That(spriteFlags.RealCentered, Is.EqualTo(false));
            Assert.That(spriteFlags.BlockHitScan, Is.EqualTo(false));
            Assert.That(spriteFlags.TranslucentReverse, Is.EqualTo(false));
            Assert.That(spriteFlags.Invisible, Is.EqualTo(false));
        }
    }
}