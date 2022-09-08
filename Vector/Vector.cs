using System;
namespace Vector
{
    public struct Vector
    {

        public double X { get; set; }
        public double Y { get; set; }

        public double Magnitude
        {
            get
            {
                return Math.Sqrt((X * X) + (Y * Y));
            }
        }
        public double Direction
        {
            get
            {
                return Math.Atan2(Y, X) * 180 / Math.PI;
            }
        }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector Add(Vector v)
        {
            //double x = this.X + v.X;
            //double y = this.Y + v.Y;
            //Vector result = new Vector();
            //result.X = x;
            //result.Y = y;

            Vector result = new Vector(this.X + v.X, this.Y + v.Y);

            return result;
        }

        public Vector Subract(Vector v)
        {
            Vector result = new Vector(this.X - v.X, this.Y - v.Y);
            return result;
        }

        public double Dot(Vector v)
        {
            return 0.0;
        }

        public double AngleBetween(Vector v)
        {
            return 0.0;
        }

        public override string ToString()
        {
            //Example:
            //<4.2,5.39>
            return $"<{X}, {Y}>";
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return a.Add(b);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return a.Subtract(b);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.Dot(b);
        }

        public static double AngleBetween(Vector a, Vector b)
        {
            return a.AngleBetween(b);
        }
    }
}
