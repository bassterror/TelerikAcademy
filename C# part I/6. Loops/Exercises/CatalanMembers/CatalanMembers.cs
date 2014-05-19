// In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:

using System;

class CatalanMembers
{
    static void Main()
    {
        decimal fac1 = 1, fac2 = 1, C;
        for (int N = 0; N < 21; N++)
        {
            fac1 = fac2 = 1;
            for (int i = 1; i < N; i++)
            {
                fac1 *= (i + 1 + N);
                fac2 *= i + 1;
            }
            C = fac1 / fac2;
            Console.WriteLine("C({0}) = {1}", N, C);
        }
        
    }
}