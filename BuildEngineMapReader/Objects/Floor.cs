namespace BuildEngineMapReader.Objects
{
    public class Floor : FloorCeiling
    {
        public Floor(float z, StatData statData, int picNum, int heightNum, int shade, int palette, Vector2 panning) : 
            base(z, statData, picNum, heightNum, shade, palette, panning)
        {
        }
    }
}