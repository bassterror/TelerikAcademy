﻿// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class DeckOfCards
{
    static void Main()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        foreach (string suit in suits)
        {
            for (int card = 2; card <= 14; card++)
            {
                switch (card)
                {
                    case 2: Console.WriteLine("2 of {0}", suit);
                        break;
                    case 3: Console.WriteLine("3 of {0}", suit);
                        break;
                    case 4: Console.WriteLine("4 of {0}", suit);
                        break;
                    case 5: Console.WriteLine("5 of {0}", suit);
                        break;
                    case 6: Console.WriteLine("6 of {0}", suit);
                        break;
                    case 7: Console.WriteLine("7 of {0}", suit);
                        break;
                    case 8: Console.WriteLine("8 of {0}", suit);
                        break;
                    case 9: Console.WriteLine("9 of {0}", suit);
                        break;
                    case 10: Console.WriteLine("10 of {0}", suit);
                        break;
                    case 11: Console.WriteLine("Jack of {0}", suit);
                        break;
                    case 12: Console.WriteLine("Queen of {0}", suit);
                        break;
                    case 13: Console.WriteLine("King of {0}", suit);
                        break;
                    case 14: Console.WriteLine("Ace of {0}", suit);
                        break;
                }
            }
        }
    }
}