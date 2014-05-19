using System;
using System.IO;
using System.Linq;

namespace Point3D
{
    public static class PathStorage
    {
        //Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
        #region Methods
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../savedPaths.txt"))
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine(String.Format("({0},{1},{2})", point.X, point.Y, point.Z));
                    writer.Flush();
                }
            }
        }
        public static Path LoadPath()
        {
            Path loadedPath = new Path();
            
            using (StreamReader reader = new StreamReader(@"../../savedPaths.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    String line = reader.ReadLine();
                    String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    Point point = new Point(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2]));
                    loadedPath.AddPoint(point);
                }
            }
            return loadedPath;
        }
        #endregion
    }
}
