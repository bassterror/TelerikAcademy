// Write a program that reads from the console a positive integer number N (N < 20)
// and outputs a matrix like the following:

using System;

class Matrix
{
    static void Main()
    {
        string a;
        int N;
        Console.Write("Enter N: ");
        if ((!int.TryParse(a = Console.ReadLine(), out N)) || N <= 0)
        {
            Console.WriteLine("Wrong number! N>0");
            Main();
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 1 + i; j <= N + i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}