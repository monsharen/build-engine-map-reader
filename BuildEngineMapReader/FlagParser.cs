using BuildEngineMapReader.Objects;

namespace BuildEngineMapReader
{
    public class FlagParser
    {
        public static StatData ParseFloorCeilingFlags(int input)
        {
            var statData = new StatData();
            statData.Parallaxing = ParseBoolFlag(input, 0);
            statData.Sloped = ParseBoolFlag(input, 1);
            statData.SwapXY = ParseBoolFlag(input, 2);
            statData.DoubleSmooshiness = ParseBoolFlag(input, 3);
            statData.XFlip = ParseBoolFlag(input, 4);
            statData.YFlip = ParseBoolFlag(input, 5);
            statData.AlignTextureToFirstWall = ParseBoolFlag(input, 6);
            return statData;
        }
        
        public static StatData ParseWallFlags(int input)
        {
            var statData = new StatData();
            statData.BlockClipMove = ParseBoolFlag(input, 0);
            statData.BottomsInvisibleSwapped = ParseBoolFlag(input, 1);
            statData.AlignPictureBottom = ParseBoolFlag(input, 2);
            statData.XFlip = ParseBoolFlag(input, 3);
            statData.Mask = ParseBoolFlag(input, 4);
            statData.OneWay = ParseBoolFlag(input, 5);
            statData.BlockHitScan = ParseBoolFlag(input, 6);
            statData.Translucent = ParseBoolFlag(input, 7);
            statData.YFlip = ParseBoolFlag(input, 8);
            statData.TranslucentReverse = ParseBoolFlag(input, 9);
            return statData;
        }
        
        public static StatData ParseSpriteFlags(int input)
        {
            var statData = new StatData();
            statData.BlockClipMove = ParseBoolFlag(input, 0);
            statData.Translucent = ParseBoolFlag(input, 1);
            statData.XFlip = ParseBoolFlag(input, 2);
            statData.YFlip = ParseBoolFlag(input, 3);
            statData.Orientation = (Sprite.Orientation)ParseIntFlag(input, 4, 2);
            statData.OneSided = ParseBoolFlag(input, 6);
            statData.RealCentered = ParseBoolFlag(input, 7);
            statData.BlockHitScan = ParseBoolFlag(input, 8);
            statData.TranslucentReverse = ParseBoolFlag(input, 9);
            statData.Invisible = ParseBoolFlag(input, 15);
            return statData;
        }

        private static bool ParseBoolFlag(int input, int index)
        {
            int mask = (1 << 1) - 1;
            int value = (input >> index) & mask;
            return value != 0;
        }
        
        private static int ParseIntFlag(int input, int index, int size)
        {
            int mask = (1 << size) - 1;
            int value = (input >> index) & mask;
            return value;
        }
    }
}