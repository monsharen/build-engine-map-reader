namespace BuildEngineMapReader.Objects
{
    public class StatData
    {
        public bool BlockClipMove { get; set; }
        public bool BottomsInvisibleSwapped { get; set; }
        public bool AlignPictureBottom { get; set; }
        
        public bool Mask { get; set; }

        public bool Translucent { get; set; }
        public bool XFlip { get; set; }
        public bool YFlip { get; set; }
        public Sprite.Orientation Orientation { get; set; }
        public bool OneSided { get; set; }
        public bool RealCentered { get; set; }
        public bool BlockHitScan { get; set; }
        public bool TranslucentReverse { get; set; }
        public bool Invisible { get; set; }
        public bool Parallaxing { get; set; }
        public bool Sloped { get; set; }
        public bool SwapXY { get; set; }
        public bool DoubleSmooshiness { get; set; }
        public bool AlignTextureToFirstWall { get; set; }
        public bool OneWay { get; set; }
    }
}