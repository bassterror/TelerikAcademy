using System;

class MyAge
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        DateTime future = now.AddYears(10);
        Console.WriteLine("Enter your birth year:");
        int YearOfBirth = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age in ten years will be: {0} ", future.Year - YearOfBirth);
    }
}
