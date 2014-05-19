// Write a program that finds the maximal increasing sequence in an array.
// Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;

class MaximalIncreasingSequence
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

        //Searches for the max sequence
        int count = 1;                               //holds the lenght of the current increasing elements
        int index = 0;                               //holds the current index of increasing elements
        int startIndex = 0;                          //holds the start index of maximal sequence
        int maxLenght = 0;                           //holds the maximal sequence        
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
                if (count > maxLenght)
                {
                    maxLenght = count;
                    startIndex = index;
                }
            }
            else
            {
                count = 1;
                index = i + 1;
            }
        }
        int endIndex = (startIndex + maxLenght) - 1;  //this is the end of the sequence

        //Output
        Console.Write("The maximal sequence of increasing elements is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}