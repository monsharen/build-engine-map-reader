namespace BuildEngineMapReader.Objects
{
    public class Sector
    {
        public int FirstWallIndex { get; set; }
        public int NumWalls { get; set; }
        public Ceiling Ceiling { get; private set; }
        public Floor Floor { get; private set; }
        public int Visibility { get; set; }
        public int LoTag { get; set; }
        public int HiTag { get; set; }
        public int Extra { get; set; }

        public EditorMeta EditorMeta { get; private set; }
        public RendererMeta RendererMeta { get; private set; }

        public Sector()
        {
            FirstWallIndex = 0; // Assuming a default value
            NumWalls = 0;
            Ceiling = new Ceiling();
            Floor = new Floor();
            Visibility = 0;
            LoTag = 0;
            HiTag = 0;
            Extra = -1;

            EditorMeta = new EditorMeta();
            RendererMeta = new RendererMeta();
        }
    }

    public class EditorMeta
    {
        // EditorMeta class definition
    }

    public class RendererMeta
    {
        // RendererMeta class definition
    }

// Include the Floor and Ceiling class definitions from the previous example
}