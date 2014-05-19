// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class AlphabetArray
{
    static void Main()
    {
        //Initializes the alphabet array
        char[] alphabet = new char[52]
        {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        
        //Raeds the word
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        //Prints the indexes
        Console.Write("The indexes are: ");
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    int number = j + 1;
                    Console.Write(number + " ");
                }
            }
        }
        Console.WriteLine();
    }
}