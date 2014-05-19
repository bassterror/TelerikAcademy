// Write a program that finds the index of given element in a sorted array of integers
// by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        //Gathers information about the array
        Console.Write("Enter number of elements for the array: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Enter element you looking for: ");
        int element = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        
        //Serches the index for the element 
        int min = 0;
        int max = size - 1;
        int mid = 0;
        while (min <= max)
        {
            mid = (max + min) / 2;

            if (array[mid] < element)
            {
                min = mid + 1;
            }
            else if (array[mid] > element)
            {
                max = mid - 1;
            }
            else
            {
                break;
            }
        }
        
        //Output
        if (array[mid] == element)
        {
            Console.WriteLine("The index is: {0}", mid);
        }
        else
        {
            Console.WriteLine("There is no such number in the array.");
        }
    }
}