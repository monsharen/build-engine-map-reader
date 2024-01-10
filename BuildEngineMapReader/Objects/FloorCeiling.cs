namespace BuildEngineMapReader.Objects
{
    public abstract class FloorCeiling
    {
        public float Z { get; }
        public StatData Stat { get; }
        public int PicNum { get;}
        public int HeightNum { get; }
        public int Shade { get; }
        public int Palette { get; }
        public Vector2 Panning { get; }

        protected FloorCeiling(float z, StatData statData, int picNum, int heightNum, int shade, int palette, Vector2 panning)
        {
            if (GetType() == typeof(FloorCeiling))
            {
                throw new System.InvalidOperationException("Cannot construct abstract instances directly");
            }
            
            Z = z;
            Stat = statData;
            PicNum = picNum;
            HeightNum = heightNum;
            Shade = shade;
            Palette = palette;
            Panning = panning;
        }
    }
}