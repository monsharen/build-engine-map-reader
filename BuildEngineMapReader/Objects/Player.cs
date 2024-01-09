using BuildEngineMapReader.Geom;

namespace BuildEngineMapReader.Objects
{
    public class Player : Position
    {
        private const int TurnSpeed = 4;
        private const int MoveSpeed = 12;

        public float Velocity { get; private set; }
        public float AngularVelocity { get; private set; }

        public float TurnDelta { get; private set; }
        public float MoveDelta { get; private set; }

        public Sector CurrentSector { get; set; } // Assuming Sector is a defined class

        public float EyeHeight { get; private set; }

        public Player(float x, float y, float z, int angle = 0) : base(x, y, z, angle)
        {
            Velocity = 0;
            AngularVelocity = 0;
            TurnDelta = 0;
            MoveDelta = 0;
            EyeHeight = 10240;
        }

        public new Player Set(float x, float y, float z, int angle = 0)
        {
            base.Set(x, y, z, angle);
            return this;
        }

        public void Update()
        {
            Velocity += (MoveSpeed * MoveDelta);
            AngularVelocity += (TurnSpeed * TurnDelta);

            if (Velocity != 0)
            {
                Velocity *= 0.9f;
                Project(Velocity);
            }
            if (AngularVelocity != 0)
            {
                AngularVelocity *= 0.8f;
                Angle += (int)AngularVelocity;
            }
            if (CurrentSector != null)
            {
                Z = CurrentSector.Floor.Z; // Assuming Floor is a property of Sector
            }
        }

        public void Turn(float delta)
        {
            TurnDelta = delta;
        }

        public void Move(float delta)
        {
            MoveDelta = delta;
        }

        public new Player Clone()
        {
            return new Player(X, Y, Z, Angle);
        }

        public new Player CopyFrom(Position point)
        {
            base.CopyFrom(point);
            return this;
        }
    }
}