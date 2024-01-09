using System;
using BuildEngineMapReader;
using NUnit.Framework;

namespace BuildEngineMapReaderTests
{
    [TestFixture]
    public class MapFileReaderTest
    {
        [Test]
        public void ShouldParseBuildMap()
        {
            const string filePath = "/Users/thomas.rosenquist/git/BuildEngineMapReader/Maps/THE_BASE.MAP";
            var mapFileReader = new MapFileReader();
            var map = mapFileReader.ReadFile(filePath);
            Console.WriteLine(map);
        }
        
        [Test]
        public void ShouldParseFloorCeilingFlags()
        {
            /*
             * Floor
             */
            var floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(2);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(false, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(16);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(20);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(22);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(56);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(true, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(84);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(true, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(false, floorCeilingFlags.YFlip);
            Assert.AreEqual(true, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(112);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(true, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(116);
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
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(48);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(49);
            Assert.AreEqual(true, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(false, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(50);
            Assert.AreEqual(false, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
            
            floorCeilingFlags = MapFileReader.ParseFloorCeilingFlags(51);
            Assert.AreEqual(true, floorCeilingFlags.Parallaxing);
            Assert.AreEqual(true, floorCeilingFlags.Sloped);
            Assert.AreEqual(false, floorCeilingFlags.SwapXY);
            Assert.AreEqual(false, floorCeilingFlags.DoubleSmooshiness);
            Assert.AreEqual(true, floorCeilingFlags.XFlip);
            Assert.AreEqual(true, floorCeilingFlags.YFlip);
            Assert.AreEqual(false, floorCeilingFlags.AlignTextureToFirstWall);
        }
    }
}