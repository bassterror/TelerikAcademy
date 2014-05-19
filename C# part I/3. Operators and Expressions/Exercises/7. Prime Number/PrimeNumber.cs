// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter integer ≤ 100: ");
        int n = int.Parse(Console.ReadLine());
        int a = 10;
        bool b = ((n % 2 > 0) && (n % 3 > 0) && (n % 5 > 0) && (n % 7 > 0)) || ((n == 2) || (n == 3) || (n == 5) || (n == 7));
        string c = (b ? "Prime" : "Not Prime");
        Console.WriteLine(c);
    }
}