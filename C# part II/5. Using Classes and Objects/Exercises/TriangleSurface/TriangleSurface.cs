// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it
// Three sides
// Two sides and an angle between them.
// Use System.Math.

using System;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("1. By side and altitude.");
            Console.WriteLine("2. By three sides.");
            Console.WriteLine("3. Two sides and an angle between them.");
            Console.Write("Select method of finding the surface: ");            
            int choice = int.Parse(Console.ReadLine()); 
            switch (choice)
            {
                case 1: 
                    UsingSideAndAltitude();
                    break;
                case 2: 
                    UsingHeronFormula();
                    break;
                default: 
                    UsingTrigonometry();
                    break;
            }
        }
 
        static void UsingSideAndAltitude()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("T = {0}", a * h / 2);
        }
 
        static void UsingHeronFormula()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());
            double s = (a + b + c) / 2;
            Console.WriteLine("T = {0}", Math.Sqrt(s*(s-a)*(s-b)*(s-c)));
        }
 
        static void UsingTrigonometry()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter an angle: ");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("T = {0}", a * b * Math.Sin(Math.PI*angle/180) / 2);
        }
    }
}