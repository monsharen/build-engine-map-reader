using BuildEngineMapReader.Objects;

namespace BuildEngineMapReader
{
    public class FlagParser
    {
        public static StatData ParseFloorCeilingFlags(int input)
        {
            return StatData.GetBuilder()
                .SetParallaxing(ParseBoolFlag(input, 0))
                .SetSloped(ParseBoolFlag(input, 1))
                .SetSwapXY(ParseBoolFlag(input, 2))
                .SetDoubleSmooshiness(ParseBoolFlag(input, 3))
                .SetXFlip(ParseBoolFlag(input, 4))
                .SetYFlip(ParseBoolFlag(input, 5))
                .SetAlignTextureToFirstWall(ParseBoolFlag(input, 6))
                .Build();
        }
        
        public static StatData ParseWallFlags(int input)
        {
            return StatData.GetBuilder()
                .SetBlockClipMove(ParseBoolFlag(input, 0))
                .SetBottomsInvisibleSwapped(ParseBoolFlag(input, 1))
                .SetAlignPictureBottom(ParseBoolFlag(input, 2))
                .SetXFlip(ParseBoolFlag(input, 3))
                .SetMask(ParseBoolFlag(input, 4))
                .SetOneWay(ParseBoolFlag(input, 5))
                .SetBlockHitScan(ParseBoolFlag(input, 6))
                .SetTranslucent(ParseBoolFlag(input, 7))
                .SetYFlip(ParseBoolFlag(input, 8))
                .SetTranslucentReverse(ParseBoolFlag(input, 9))
                .Build();
        }
        
        public static StatData ParseSpriteFlags(int input)
        {
            return StatData.GetBuilder()
                .SetBlockClipMove(ParseBoolFlag(input, 0))
                .SetTranslucent(ParseBoolFlag(input, 1))
                .SetXFlip(ParseBoolFlag(input, 2))
                .SetYFlip(ParseBoolFlag(input, 3))
                .SetOrientation((Sprite.Orientation)ParseIntFlag(input, 4, 2))
                .SetOneSided(ParseBoolFlag(input, 6))
                .SetRealCentered(ParseBoolFlag(input, 7))
                .SetBlockHitScan(ParseBoolFlag(input, 8))
                .SetTranslucentReverse(ParseBoolFlag(input, 9))
                .SetInvisible(ParseBoolFlag(input, 15)).Build();
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