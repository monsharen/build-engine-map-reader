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
        
        public static Builder GetBuilder()
        {
            return new Builder();
        }

        public StatData(bool blockClipMove, bool bottomsInvisibleSwapped, bool alignPictureBottom, bool mask, bool translucent, bool xFlip, bool yFlip, Sprite.Orientation orientation, bool oneSided, bool realCentered, bool blockHitScan, bool translucentReverse, bool invisible, bool parallaxing, bool sloped, bool swapXy, bool doubleSmooshiness, bool alignTextureToFirstWall, bool oneWay)
        {
            BlockClipMove = blockClipMove;
            BottomsInvisibleSwapped = bottomsInvisibleSwapped;
            AlignPictureBottom = alignPictureBottom;
            Mask = mask;
            Translucent = translucent;
            XFlip = xFlip;
            YFlip = yFlip;
            Orientation = orientation;
            OneSided = oneSided;
            RealCentered = realCentered;
            BlockHitScan = blockHitScan;
            TranslucentReverse = translucentReverse;
            Invisible = invisible;
            Parallaxing = parallaxing;
            Sloped = sloped;
            SwapXY = swapXy;
            DoubleSmooshiness = doubleSmooshiness;
            AlignTextureToFirstWall = alignTextureToFirstWall;
            OneWay = oneWay;
        }

        public class Builder
        {
            private bool BlockClipMove;
            private bool BottomsInvisibleSwapped;
            private bool AlignPictureBottom;
            private bool Mask;
            private bool Translucent;
            private bool XFlip;
            private bool YFlip;
            private Sprite.Orientation Orientation;
            private bool OneSided;
            private bool RealCentered;
            private bool BlockHitScan;
            private bool TranslucentReverse;
            private bool Invisible;
            private bool Parallaxing;
            private bool Sloped;
            private bool SwapXY;
            private bool DoubleSmooshiness;
            private bool AlignTextureToFirstWall;
            private bool OneWay;
            
            public Builder SetBlockClipMove(bool blockClipMove)
            {
                BlockClipMove = blockClipMove;
                return this;
            }
            
            public Builder SetBottomsInvisibleSwapped(bool bottomsInvisibleSwapped)
            {
                BottomsInvisibleSwapped = bottomsInvisibleSwapped;
                return this;
            }
            
            public Builder SetAlignPictureBottom(bool alignPictureBottom)
            {
                AlignPictureBottom = alignPictureBottom;
                return this;
            }
            
            public Builder SetMask(bool mask)
            {
                Mask = mask;
                return this;
            }
            
            public Builder SetTranslucent(bool translucent)
            {
                Translucent = translucent;
                return this;
            }
            
            public Builder SetXFlip(bool xFlip)
            {
                XFlip = xFlip;
                return this;
            }
            
            public Builder SetYFlip(bool yFlip)
            {
                YFlip = yFlip;
                return this;
            }
            
            public Builder SetOrientation(Sprite.Orientation orientation)
            {
                Orientation = orientation;
                return this;
            }
            
            public Builder SetOneSided(bool oneSided)
            {
                OneSided = oneSided;
                return this;
            }
            
            public Builder SetRealCentered(bool realCentered)
            {
                RealCentered = realCentered;
                return this;
            }
            
            public Builder SetBlockHitScan(bool blockHitScan)
            {
                BlockHitScan = blockHitScan;
                return this;
            }
            
            public Builder SetTranslucentReverse(bool val)
            {
                TranslucentReverse = val;
                return this;
            }
            
            public Builder SetInvisible(bool invisible)
            {
                Invisible = invisible;
                return this;
            }
            
            public Builder SetParallaxing(bool parallaxing)
            {
                Parallaxing = parallaxing;
                return this;
            }
            
            public Builder SetSloped(bool sloped)
            {
                Sloped = sloped;
                return this;
            }
            
            public Builder SetSwapXY(bool swapXY)
            {
                SwapXY = swapXY;
                return this;
            }
            
            public Builder SetDoubleSmooshiness(bool doubleSmooshiness)
            {
                DoubleSmooshiness = doubleSmooshiness;
                return this;
            }
            
            public Builder SetAlignTextureToFirstWall(bool alignTextureToFirstWall)
            {
                AlignTextureToFirstWall = alignTextureToFirstWall;
                return this;
            }
            
            public Builder SetOneWay(bool oneWay)
            {
                OneWay = oneWay;
                return this;
            }

            public StatData Build()
            {
                return new StatData(BlockClipMove, BottomsInvisibleSwapped, AlignPictureBottom,
                    Mask, Translucent, XFlip, YFlip, Orientation, OneSided, RealCentered, BlockHitScan,
                    TranslucentReverse,
                    Invisible, Parallaxing, Sloped, SwapXY, DoubleSmooshiness, AlignTextureToFirstWall, OneWay);
            }
        }
    }
}