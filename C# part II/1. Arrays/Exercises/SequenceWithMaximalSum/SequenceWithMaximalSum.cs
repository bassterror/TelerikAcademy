// Write a program that finds the sequence of maximal sum in given array.
// Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class SequenceWithMaximalSum
{
    static void Main()
    {
        //Gathers information about the array
        Console.Write("Enter number of elements for the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        //Searches for the maximal sum
        int maxSum = array[0];                    //holds the max sum (first time with value of the first element)
        int tempMax = array[0];                   //holds the current max sum (first time with value of the first element)
        int firstIndex = 0;                       //holds the index of the first element of the max sum
        int tempIndex = 0;                        //holds the index of the current first element of the max sum
        int lastIndex = 0;                        //holds the index of the last element if the max sum
        for (int i = 1; i < size; i++)
        {
            if (tempMax < 0)
            {
                tempMax = array[i];
                tempIndex = i;
            }
            else
            {
                tempMax += array[i];
            }

            if (tempMax > maxSum)
            {
                maxSum = tempMax;

                firstIndex = tempIndex;
                lastIndex = i;
            }
        }

        //Output
        Console.WriteLine("The sequence with maximal sum is: ");
        for (int i = firstIndex; i <= lastIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}