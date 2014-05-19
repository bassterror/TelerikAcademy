// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());

        if (N > 1 && K > N)
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
            decimal dif = 1;
            for (int d = 1; d <= (K - N); d++)
            {
                dif *= d;
            }

            decimal m = fN * fK;
            decimal r = m / dif;

            Console.WriteLine("({0}!*{1}!) / ({1}-{0})! = {2}", N, K, r);
        }
        else
        {
            Console.WriteLine("Wrong input! Correct input is 1<N<K");
        }
    }
}