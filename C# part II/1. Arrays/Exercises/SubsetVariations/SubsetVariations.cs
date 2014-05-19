// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// Example:	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class SubsetVariations
{
    static void Main()
    {
        //Collect info
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        //Generates and prints variations
        for (int i = 0; i < Math.Pow(n, k); i++)
        {
            int temp = i;
            int[] array = new int[k];
            for (int j = 0; j < k; j++)
            {
                array[k - j - 1] = temp % n;
                temp = temp / n;
            }

            Console.Write("{0}{1}", '{', array[0] + 1);
            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", array[j] + 1);
            }
            Console.WriteLine("}");
        }
    }
}