// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class Sum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int X = int.Parse(Console.ReadLine());

        decimal fN = 1;
        decimal qx = 1;
        decimal s = 1;
        for (int i = 1; i <= N; i++)
        {
            fN *= i;
            qx *= X;
            s += fN / qx;
        }
        Console.WriteLine("1 + N!/x^N = {0}", s);
    }
}