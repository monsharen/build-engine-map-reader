namespace BuildEngineMapReader.Objects
{
    public class Flag
    {
        public Flag(string name, int index, int? size)
        {
            Name = name;
            Index = index;
            Size = size;
        }
    
        public string Name { get; }

        public int Index { get; }
        
        public int? Size { get; }
    }
}
