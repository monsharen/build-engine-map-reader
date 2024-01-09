namespace BuildEngineMapReader.Objects
{
    public abstract class FloorCeiling
    {
        public float Z { get; set; }
        public StatData Stat { get; set; }
        public int PicNum { get; set; }
        public int HeightNum { get; set; }
        public int Shade { get; set; }
        public int Palette { get; set; }
        public Vector2 Panning { get; set; }

        protected FloorCeiling()
        {
            if (GetType() == typeof(FloorCeiling))
            {
                throw new System.InvalidOperationException("Cannot construct abstract instances directly");
            }

            Z = 0;
            Stat = new StatData();
            Panning = new Vector2();
        }
    }
}