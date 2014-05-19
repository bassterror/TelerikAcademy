// Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


using System;

class MaximalSequenceOfEqualElements
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
        int element = 0;              //holds the repeating element
        int count = 1;                //holds the lenght of the current repeating elements
        int maxLenght = 0;            //holds the maximal sequence
        for (int i = 0; i < size - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
                if (count > maxLenght)
                {
                    maxLenght = count;
                    element = array[i];
                }
            }
            else
            {
                count = 1;
            }
        }

        //Output
        Console.Write("The maximal sequence of equal elements is: ");
        for (int i = 0; i < maxLenght; i++)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}