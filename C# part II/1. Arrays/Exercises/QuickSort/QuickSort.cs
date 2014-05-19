// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSort
{
    static void Main()
    {
        //Gathers information about the array
        Console.Write("Enter number of elements for the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int[] sortedArray = new int[size];
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //
        int pivot = array[size / 2];
        int leftSize = 0;
        int rightSize = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > pivot)
            {
                rightSize++;
            }
            else
            {
                leftSize++;
            }
        }

        int[] left = new int[leftSize];
        int[] right = new int[rightSize];
        int leftIndex = 0;
        int rightIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > pivot)
            {
                right[rightIndex] = array[i];
                rightIndex++;
            }
            else
            {
                left[leftIndex] = array[i];
                leftIndex++;
            }
        }

        for (int i = 0; i < left.Length; i++)
        {
            for (int p = i; p < left.Length; p++)
            {
                if (left[i] > left[p])
                {
                    int temp = left[i];
                    left[i] = left[p];
                    left[p] = temp;
                }
            }
        }

        for (int i = 0; i < right.Length; i++)
        {
            for (int p = i; p < right.Length; p++)
            {
                if (right[i] > right[p])
                {
                    int temp = right[i];
                    right[i] = right[p];
                    right[p] = temp;
                }
            }
        }
        
        if (left.Length > 0 && right.Length > 0)
        {
            for (int i = 0; i < left.Length; i++)
            {
                
                sortedArray[i] = left[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                sortedArray[left.Length + i] = right[i];
            }
        }
        else if (left.Length == 0)
        {
            for (int i = 0; i < right.Length; i++)
            {
                sortedArray[i] = right[i];
            }
        }
        else if (right.Length == 0)
        {
            for (int i = 0; i < left.Length; i++)
            {
                sortedArray[i] = left[i];
            }
        }

        //Output
        Console.WriteLine("Sorted array is:");
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }
        Console.WriteLine();
    }
}