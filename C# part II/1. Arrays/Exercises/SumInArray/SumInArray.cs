// Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1,  4, 2, 5, 8}, S=11  {4, 2, 5}

using System;

class SumInArray
{
    static void Main()
    {
        //Gathers information about the array
        Console.Write("Enter number of elements for the array: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Enter sum: ");
        int s = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //Serches for the given sum
        int tempSum = 0;
        int firstIndex, lastIndex;
        bool isThere = false;
        for (int i = 0; i < size - 1; i++)
        {
            tempSum = array[i];
            firstIndex = i;
            for (int j = i + 1; j < size; j++)
            {
                tempSum += array[j];
                lastIndex = j;
                if (tempSum > s)
                {
                    tempSum = 0;
                    break;
                }
                //Output
                else if (tempSum == s)
                {
                    isThere = true;
                    Console.WriteLine("A sequence with given sum is:");
                    for (int k = firstIndex; k <= lastIndex; k++)
                    {
                        Console.Write(array[k] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        if (isThere == false)
        {
            Console.WriteLine("There are no sequences with this sum!");
        }
    }
}