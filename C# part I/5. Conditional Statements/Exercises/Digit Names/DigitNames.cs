// Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class DigitNames
{
    static void Main()
    {
        Console.Write("Enter digit [0...9]: ");
        byte a = byte.Parse(Console.ReadLine());
        string b = "";
        switch (a)
        {
            case 0:
                b = "Zero";
                break;
            case 1:
                b = "One";
                break;
            case 2:
                b = "Two";
                break;
            case 3:
                b = "Three";
                break;
            case 4:
                b = "Four";
                break;
            case 5:
                b = "Five";
                break;
            case 6:
                b = "Six";
                break;
            case 7:
                b = "Seven";
                break;
            case 8:
                b = "Eight";
                break;
            case 9:
                b = "Nine";
                break;
            default: Console.WriteLine("Not a digit!");
                break;
        }
        Console.WriteLine("The name of the digit you entered is: {0}", b);
    }
}