// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class MaxSum
{
    static void Main()
    {
        //Gathers information about the array
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K:");
        int k = int.Parse(Console.ReadLine());
        if (k > n)
        {
            Console.WriteLine("Wrong input! Must be: N > K");
            Main();
        }
        else
        {            
            int[] array = new int[n];
            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Searches for the maximal sum
            Array.Sort(array);             //This sorts the biggest element in the end of the array
            int maxSum = 0;                   //holds the maximal sum
            for (int i = n - 1; i >= n - k; i--)
            {
                maxSum += array[i];
            }

            //Output
            Console.WriteLine("The maximal sum of K elements in the array is: {0}", maxSum);
        }       
    }
}