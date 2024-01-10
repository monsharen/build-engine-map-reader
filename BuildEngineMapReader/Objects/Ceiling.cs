namespace BuildEngineMapReader.Objects
{
    public class Ceiling : FloorCeiling
    {
        // Additional properties or methods specific to Ceiling
        public Ceiling(float z, StatData statData, int picNum, int heightNum, int shade, int palette, Vector2 panning) : 
            base(z, statData, picNum, heightNum, shade, palette, panning)
        {
        }
    }
}