using System;

namespace Nau.Lib
{
    public abstract class Shape
    {
        private int npoints;
        private int[] xpoints;
        private int[] ypoints;

        private const int MIN_LENGTH = 3;

        public Shape(int npoints, int[] xpoints, int[] ypoints)
        {
            ValidatePoints(npoints, xpoints, ypoints);
            ValidateNumberOfPoints(npoints);

            this.npoints = npoints;
            this.xpoints = xpoints;
            this.ypoints = ypoints;
        }

        protected virtual void ValidateNumberOfPoints(int npoints)
        {
            if (npoints < MIN_LENGTH)
            {
                throw new ArgumentOutOfRangeException("npoints < " + MIN_LENGTH);
            }
        }

        protected int GetXPointByIndex(int index)
        {
            if (index > npoints)
            {
                throw new IndexOutOfRangeException();
            }

            return xpoints[index];
        }

        protected int GetYPointByIndex(int index)
        {
            if (index > npoints)
            {
                throw new IndexOutOfRangeException();
            }

            return ypoints[index];
        }

        private void ValidatePoints(int npoints, int[] xpoints, int[] ypoints)
        {
            if (npoints > xpoints.Length || npoints > ypoints.Length)
            {
                throw new IndexOutOfRangeException("npoints > xpoints.length || " +
                                                    "npoints > ypoints.length");
            }
        }

        public int CountSideLength(int side)
        {

            if (side > npoints)
            {
                throw new ArgumentOutOfRangeException("Thre is only " + npoints + " sides");
            }

            int a = side;
            int b = side + 1;
            if (b == npoints)
            {
                b = 0;
            }

            return (int)Math.Sqrt(Math.Pow(xpoints[b] - xpoints[a], 2) + Math.Pow(ypoints[b] - ypoints[a], 2));
        }
    }
}
