using System;
using System.Linq;

namespace Point3D
{
    public struct Point
    {
        #region Fields
        //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
        private int x;
        private int y;
        private int z;
        //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
        private static readonly Point startCoordSys = new Point(0, 0, 0);
        #endregion

        #region Properties
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        //Add a static property to return the point O.
        public static Point ZeroPoint()
        {
            return startCoordSys;
        }
        #endregion

        #region Constructors
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion

        #region Methods
        //Implement the ToString() to enable printing a 3D point.
        public override string ToString()
        {
            return String.Format("({0:F2}, {1:F2}, {2:F2})", x, y, z);
        }
        #endregion
    }
}