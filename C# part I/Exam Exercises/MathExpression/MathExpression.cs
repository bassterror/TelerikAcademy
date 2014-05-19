using System;
using System.Threading;
using System.Globalization;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        bool condition = ((n < -10000000 || n > 10000000) || (m < -10000000 || m > 10000000) || (p < -10000000 || p > 10000000) || (m == 0 || p == 0));

        if (!condition)
        {
            double a = (n * n) + (1 / (m * p) + 1337);
            double b = n - (128.523123123 * p);
            int x = (int)m % 180;
            double result;
            if (b != 0)
            {
                result = ((a / b) + Math.Sin(x));
                Console.WriteLine("{0:F6}", result);
            }
        }
    }
}
