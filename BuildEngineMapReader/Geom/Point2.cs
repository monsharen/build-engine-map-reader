using System;

namespace BuildEngineMapReader.Geom
{
    public class Point2
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Point2(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
        }
    }
}