using System;
using System.Linq;

namespace Point3D
{
    public static class Distance
    {
        //Write a static class with a static method to calculate the distance between two points in the 3D space.
        public static double CalculateDist(Point p1, Point p2)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2) + Math.Pow((p1.Z - p2.Z), 2));
            return distance;
        }
    }
}
