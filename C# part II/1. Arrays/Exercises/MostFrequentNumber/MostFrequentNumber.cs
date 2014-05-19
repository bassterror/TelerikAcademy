// Write a program that finds the most frequent number in an array.
// Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class MostFrequentNumber
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

        //Serches for the most frequent number
        Array.Sort(array);
        int count = 1;
        int tempCount = 1;
        int element = array[0];
        for (int i = 1; i < size - 1; i++)
        {
            if (array[0] == array[i])
            {
                count++;
            }
            if (array[i] == array[i + 1])
            {
                tempCount++;
                if (tempCount > count)
                {
                    count = tempCount;
                    element = array[i];
                }
            }            
            else
            {
                tempCount = 1;
            }
        }

        //Output
        Console.WriteLine("The most frequent number in the array is: {0} ({1} times)", element, count);
    }
}