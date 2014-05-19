// Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        
        if (K > 1 && N > K)
        {
            decimal fN = 1;
            for (int i = 1; i <= N; i++)
            {
                fN *= i;
            }
            decimal fK = 1;
            for (int j = 1; j <= K; j++)
            {
                fK *= j;
            }
            Console.WriteLine("{0}!/{1}! = {2}", N, K, fN / fK);
        }
        else
        {
            Console.WriteLine("Wrong input! Correct input is 1<K<N");           
        }
    }
}