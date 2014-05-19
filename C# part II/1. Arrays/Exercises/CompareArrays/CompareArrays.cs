// Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        //Gathers information about the arrays        
        Console.Write("Enter number of elements for the first array: ");
        int size1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number of elements for the second array: ");
        int size2 = int.Parse(Console.ReadLine());
        if (size1 == size2)
        {
            string[] array1 = new string[size1];
            string[] array2 = new string[size2];
            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < size1; i++)
            {
                array1[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter elements of the second array:");
            for (int i = 0; i < size2; i++)
            {
                array2[i] = Console.ReadLine();
            }

            //Compares the arrays
            bool compare = true;
            for (int i = 0; i < size1; i++)
            {
                if (array1[i] != array2[i])
                {
                    compare = false;
                    break;
                }
            }
            Console.WriteLine("The arrays are {0}!", compare == false ? "diffrent" : "the same");
        }
        else
        {
            Console.WriteLine("The arrays are different!");
        }        
    }
}
