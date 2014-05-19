// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareArraysLexicographically
{
    static void Main()
    {
        //Gathers information about the arrays        
        Console.Write("Enter number of elements for the first array: ");
        int size1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number of elements for the second array: ");
        int size2 = int.Parse(Console.ReadLine());
        char[] array1 = new char[size1];
        char[] array2 = new char[size2];
        Console.WriteLine("Enter chars of the first array:");
        for (int i = 0; i < size1; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter chars of the second array:");
        for (int i = 0; i < size2; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }
        
        int smaller;
        if (size1 <= size2)
        {
            smaller = size1;            
        }
        else
        {
            smaller = size2;
        }
        
        //Compares the arrays
        int compare = 0;
        for (int i = 0; i < smaller; i++)
        {
            if (array1[i] < array2[i])
            {
                compare = 1;
                break;
            }
            else
            {
                compare = 2;
                break;
            }
        }
        if (compare == 1)
        {
            Console.WriteLine("The first array is earlier!");
        }
        else if (compare == 2)
        {
            Console.WriteLine("The second array is earlier!");
        }
        else
        {
            if (size1 < size2)
            {
                Console.WriteLine("The first array is earlier!");
            }
            else if (size1 > size2)
            {
                Console.WriteLine("The second array is earlier!");
            }
            else
            {
                Console.WriteLine("The arrays are the same!");
            }
        }
    }
}