using System;

class First10MembersOfASequence
{
    static void Main()
    {
        Console.WriteLine("There is a sequence: 2, -3, 4, -5, 6, -7");
        Console.WriteLine("The first 10 numbers of the sequence are:");
        for (int i = 2; i < 12; i = i + 2)
        {
            Console.Write(" " + i);
            Console.Write(", " + -(i + 1) + ",");
        }
        Console.WriteLine();
    }
}