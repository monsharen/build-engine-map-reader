namespace BuildEngineMapReader.Objects
{
    public class FlagConstants
    {
        public static readonly Flag[] FloorCeilingFlagsMap = 
        {
            new Flag("parallaxing", 0, null),
            new Flag("sloped", 1, null),
            new Flag("swapXY", 2, null),
            new Flag("doubleSmooshiness", 3, null),
            new Flag("xFlip", 4, null),
            new Flag("yFlip", 5, null),
            new Flag("alignTextureToFirstWall", 6, null)
        };

        public static readonly Flag[] WallFlagsMap =
        {
            new Flag("blockClipMove", 0, null),
            new Flag("bottomsInvisibleSwapped", 1, null),
            new Flag("alignPictureBottom", 2, null),
            new Flag("xFlip", 3, null),
            new Flag("mask", 4, null),
            new Flag("oneWay", 5, null),
            new Flag("blockHitScan", 6, null),
            new Flag("translucent", 7, null),
            new Flag("yFlip", 8, null),
            new Flag("translucentReverse", 9, null)
        };

        public static readonly Flag[] SpriteFlagsMap =
        {
            new Flag("blockClipMove", 0, null),
            new Flag("translucent", 1, null),
            new Flag("xFlip", 2, null),
            new Flag("yFlip", 3, null),
            new Flag("orientation", 4, 2),
            new Flag("oneSided", 6, null),
            new Flag("realCentered", 7, null),
            new Flag("blockHitScan", 8, null),
            new Flag("translucentReverse", 9, null),
            new Flag("invisible", 15, null)
        };
    }
}