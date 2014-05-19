using System;
using System.Linq;

namespace Point3D
{
    class Point3DMain
    {
        static void Main()
        {
            Path path1 = new Path();
            path1.AddPoint(new Point(1, 2, 3));
            path1.AddPoint(new Point(5, 8, 2));
            path1.AddPoint(new Point(6, 2, 1));
            path1.AddPoint(new Point(9, 3, 7));
            path1.AddPoint(new Point(3, 1, 4));
            path1.AddPoint(new Point(7, 5, 3));
            PathStorage.SavePath(path1);

            Path path2 = PathStorage.LoadPath();
            path2.PrintPath();
        }
    }
}
