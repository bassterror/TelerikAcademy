//You are given an array of strings. Write a method that sorts the array by the length
//of its elements (the number of characters composing them).

using System;

class SortArray
{
    static void Main()
    {
        //Gathers info
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        string[] unsortedArray = new string[size];
        int[] elementLengths = new int[size];
        for (int i = 0; i < size; i++)
        {
            unsortedArray[i] = Console.ReadLine();
            elementLengths[i] = unsortedArray[i].Length;
        }
        Console.WriteLine();

        //Sorts the elements in the array
        Array.Sort(elementLengths, unsortedArray);
        for (int i = 0; i < size; i++)
        {
            Console.Write(unsortedArray[i] + " ");
        }
        Console.WriteLine();
    }
}