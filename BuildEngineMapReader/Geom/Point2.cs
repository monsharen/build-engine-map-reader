using System;

namespace BuildEngineMapReader.Geom
{
    public class Point2
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Point2(float x = 0, float y = 0)
        {
            Set(x, y);
        }

        public Point2 Set(float x, float y)
        {
            X = x;
            Y = y;
            return this;
        }

        public Point2 Translate(float deltaX, float deltaY)
        {
            X += deltaX;
            Y += deltaY;
            return this;
        }

        public Point2 Add(Point2 point)
        {
            X += point.X;
            Y += point.Y;
            return this;
        }

        public Point2 Subtract(Point2 point)
        {
            X -= point.X;
            Y -= point.Y;
            return this;
        }

        public Point2 Centroid(Point2 point)
        {
            return new Point2((X + point.X) * 0.5f, (Y + point.Y) * 0.5f);
        }

        public Point2 Round()
        {
            X = (float) Math.Round(X);
            Y = (float) Math.Round(Y);
            return this;
        }

        public float Distance(Point2 point)
        {
            return Point2.Distance(this, point);
        }

        public Point2 Clone()
        {
            return new Point2(X, Y);
        }

        public Point2 CopyFrom(Point2 point)
        {
            X = point.X;
            Y = point.Y;
            return this;
        }

        public static Point2 Rotate(Point2 point, Point2 origin, float angle)
        {
            throw new Exception("Not implemented");
        }

        public static Point2 Subtract(Point2 p1, Point2 p2)
        {
            return p1.Clone().Subtract(p2);
        }

        public static float Distance(Point2 p1, Point2 p2)
        {
            throw new Exception("Not implemented");
        }

        public static float DistanceSquared(Point2 p1, Point2 p2)
        {
            throw new Exception("Not implemented");
        }

        public static object ClosestPointOnLine(Point2 startPoint, Point2 endPoint, Point2 point)
        {
            var line = endPoint.Clone().Subtract(startPoint);
            var lineLengthSquared = line.X * line.X + line.Y * line.Y;
            var dotProduct = ((point.X - startPoint.X) * line.X + (point.Y - startPoint.Y) * line.Y) / lineLengthSquared;
            var closestPoint = new Point2(
                startPoint.X + dotProduct * line.X,
                startPoint.Y + dotProduct * line.Y
            );
            var distanceSquared = DistanceSquared(point, closestPoint);
            return new
            {
                Point = closestPoint,
                DistanceSquared = distanceSquared
            };
        }
    }
}