using System;
using Map.Geom;

namespace BuildEngineMapReader.Geom
{
    public class Position : Point3
    {
        private int _angle;

        public Position() : base()
        {
            Angle = 0;
        }
        
        public Position(float x, float y, float z, int angle = 0) : base(x, y, z)
        {
            Angle = angle;
        }

        public new Position Set(float x, float y, float z, int angle = 0)
        {
            base.Set(x, y, z);
            Angle = angle;
            return this;
        }

        public new Position Clone()
        {
            return new Position(X, Y, Z, _angle);
        }

        public new Position CopyFrom(Position point)
        {
            base.CopyFrom(point);
            _angle = point.Angle;
            return this;
        }

        public Position Project(float magnitude)
        {
            X += magnitude * (float)Math.Cos(AngleRadians);
            Y += magnitude * (float)Math.Sin(AngleRadians);
            return this;
        }

        public int Angle
        {
            get => _angle;
            set => _angle = ((value % 2047) + 2047) % 2047;
        }

        public float AngleDegrees
        {
            get => Angle / 5.7f;
            set => Angle = (int)(value * 5.7f);
        }

        public float AngleRadians
        {
            get => (float)(AngleDegrees * Math.PI) / 180;
            set => AngleDegrees = (value / (float)Math.PI) * 180;
        }

        public static float ToDegrees(int angle)
        {
            return angle / 5.7f;
        }

        public static float ToRadians(int angle)
        {
            return (ToDegrees(angle) * (float)Math.PI) / 180;
        }
    }
}