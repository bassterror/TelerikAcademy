using System;
using System.Linq;
using System.Numerics;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            int  n = int.Parse(Console.ReadLine());
            BigInteger[] sequence = new BigInteger[n];
            sequence[0] = a;
            sequence[1] = b;
            sequence[2] = c;
            for (int i = 3; i < n; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
            }
            Console.WriteLine(sequence[n-1]);
        }
    }
}
