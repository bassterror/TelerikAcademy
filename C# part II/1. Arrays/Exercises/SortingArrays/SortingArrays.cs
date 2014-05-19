// Sorting an array means to arrange its elements in increasing order.
// Write a program to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SortingArrays
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

        //Sorting the array
        int indexMin;        //holds the current index with minimal value
        int temp;
        for (int i = 0; i < size - 1; i++)
        {
            indexMin = i;
            for (int j = i + 1; j < size; j++)
            {
                if (array[j] < array[indexMin])
                {
                    indexMin = j;
                }
            }
            if (indexMin != i)
            {
                temp = array[i];
                array[i] = array[indexMin];
                array[indexMin] = temp;
            }
        }

        //Output
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}