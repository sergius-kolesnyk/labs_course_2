using System;

namespace Nau.Lib
{
    public class Trianle : Shape
    {
        private const int MAX_SIDE = 3;

        private double a;
        private double b;
        private double c;

        public int GetXCoordinate(char point)
        {
            switch (point)
            {
                case 'A':
                    return base.GetXPointByIndex(0);
                case 'B':
                    return base.GetXPointByIndex(1);
                case 'C':
                    return base.GetXPointByIndex(2);
                default:
                    throw new ArgumentException();
            }
        }

        public int GetYCoordinate(char point)
        {
            switch (point)
            {
                case 'A':
                    return base.GetYPointByIndex(0);
                case 'B':
                    return base.GetYPointByIndex(1);
                case 'C':
                    return base.GetYPointByIndex(2);
                default:
                    throw new ArgumentException();
            }
        }

        public Trianle(int npoints, int[] xpoints, int[] ypoints) : base(npoints, xpoints, ypoints)
        {
            a = CountSideLength(0);
            b = CountSideLength(1);
            c = CountSideLength(2);
        }

        protected override void ValidateNumberOfPoints(int npoints)
        {
            base.ValidateNumberOfPoints(npoints);

            if (npoints > MAX_SIDE)
            {
                throw new ArgumentOutOfRangeException("npoints > " + MAX_SIDE);
            }
        }

        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }
    }
}
