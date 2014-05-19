// Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
// The program must show the value of that variable as a console output. Use switch statement.

using System;
using System.Threading;
using System.Globalization;

class UserChoice
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Enter 1 for int, 2 for double, 3 for string: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter int: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2:
                Console.Write("Enter double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b + 1);
                break;
            case 3:
                Console.Write("Enter string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}