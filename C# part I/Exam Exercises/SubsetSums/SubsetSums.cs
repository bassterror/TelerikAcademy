using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] elements = new long[n];

        for (int i = 0; i < n; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }

        int counter = 0;
        for (int i = 1; i <= (int)Math.Pow(2, n) - 1; i++)
        {
            long currentSum = 0;
            for (int j = 1; j <= n; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    if (j == 1)
                    {
                        currentSum += elements[0];
                    }
                    if (j == 2)
                    {
                        currentSum += elements[1];
                    }
                    if (j == 3)
                    {
                        currentSum += elements[2];
                    }
                    if (j == 4)
                    {
                        currentSum += elements[3];
                    }
                    if (j == 5)
                    {
                        currentSum += elements[4];
                    }
                    if (j == 6)
                    {
                        currentSum += elements[5];
                    }
                    if (j == 7)
                    {
                        currentSum += elements[6];
                    }
                    if (j == 8)
                    {
                        currentSum += elements[7];
                    }
                    if (j == 9)
                    {
                        currentSum += elements[8];
                    }
                    if (j == 10)
                    {
                        currentSum += elements[9];
                    }
                    if (j == 11)
                    {
                        currentSum += elements[10];
                    }
                    if (j == 12)
                    {
                        currentSum += elements[11];
                    }
                    if (j == 13)
                    {
                        currentSum += elements[12];
                    }
                    if (j == 14)
                    {
                        currentSum += elements[13];
                    }
                    if (j == 15)
                    {
                        currentSum += elements[14];
                    }
                    if (j == 16)
                    {
                        currentSum += elements[15];
                    }
                }
            }
            if (currentSum == s)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
