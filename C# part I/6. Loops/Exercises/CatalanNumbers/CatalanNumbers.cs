// Write a program to calculate the Nth Catalan number by given N.

using System;

class CatalanNumbers
{
    static void Main()
    {
        string a;
        int N;
        decimal fac1 = 1, fac2 = 1, C;
        Console.Write("Which member of The Catalan sequence do you want?: ");
        if ((!int.TryParse(a = Console.ReadLine(), out N)) || N < 0)
        {
            Console.WriteLine("Wrong member! n=>0");
            Main();
        }
        else
        {
            for (int i = 1; i < N; i++)
            {
                fac1 *= (i + 1 + N);
                fac2 *= i + 1;
            }
            C = fac1 / fac2;
            Console.WriteLine("The C({1}) is: {0}", C, N);
        }
    }
}