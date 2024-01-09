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
        
        
    }
}