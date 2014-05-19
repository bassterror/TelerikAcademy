using System;
using System.Collections.Generic;
using System.Linq;

namespace Point3D
{
    public class Path
    {
        //Create a class Path to hold a sequence of points in the 3D space.
        #region Fields
        private List<Point> points;
        #endregion 

        #region Constructors
        public Path()
        {
            points = new List<Point>();
        }
        #endregion

        #region Properties
        public List<Point> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
        #endregion

        #region Methods
        public void AddPoint(Point point)
        {
            Points.Add(point);
        }
        public void PrintPath()
        {
            Console.WriteLine("Path:");
            foreach (var point in points)
            {
                Console.WriteLine("({0},{1},{2})", point.X, point.Y, point.Z);
            }
        }
        #endregion
    }
}
