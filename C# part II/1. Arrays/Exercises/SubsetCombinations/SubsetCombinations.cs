// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
// Example:	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class SubsetCombinations
{
    static void Main()
    {
        //Collect info        
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Generates array [1...N]
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        int combinations = (int)(Math.Pow(2, n) - 1);

        //Generates and prints combinations
        for (int i = 1; i <= combinations; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                byte bit = (byte)(i >> j & 1);
                if (bit == 1)
                {
                    count++;
                }
            }

            if (count == k)
            {
                for (int j = 0; j < n; j++)
                {
                    byte bit = (byte)(i >> j & 1);
                    if (bit == 1)
                    {
                        Console.Write(array[j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}