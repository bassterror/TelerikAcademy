using System;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger playerOneMatchScore = 0;
        BigInteger playerTwoMatchScore = 0;
        int playerOneGames = 0;
        int playerTwoGames = 0;
        bool playerOneXCard = false;
        bool playerTwoXCard = false;
        
        for (int j = 0; j < n; j++)
        {
            int playerOneGamePoints = 0;
            int playerTwoGamePoints = 0;

            for (int i = 0; i < 3; i++)
            {
                string playerOneCard = Console.ReadLine();
                switch (playerOneCard)
                {                                       
                    case "A":
                        playerOneGamePoints += 1;
                        break;
                    case "J":
                        playerOneGamePoints += 11;
                        break;
                    case "Q":
                        playerOneGamePoints += 12;
                        break;
                    case "K":
                        playerOneGamePoints += 13;
                        break;
                    case "Z":
                        playerOneMatchScore *= 2;
                        break;
                    case "Y":
                        playerOneMatchScore -= 200;
                        break;
                    case "X":
                        playerOneXCard = true;
                        break;
                    default:
                        playerOneGamePoints += 12 - int.Parse(playerOneCard);
                        break;
                }
            }            
                       
            for (int i = 0; i < 3; i++)
            {
                string playerTwoCard = Console.ReadLine();
                switch (playerTwoCard)
                {
                    case "A":
                        playerTwoGamePoints += 1;
                        break;
                    case "J":
                        playerTwoGamePoints += 11;
                        break;
                    case "Q":
                        playerTwoGamePoints += 12;
                        break;
                    case "K":
                        playerTwoGamePoints += 13;
                        break;
                    case "Z":
                        playerTwoMatchScore *= 2;
                        break;
                    case "Y":
                        playerTwoMatchScore -= 200;
                        break;
                    case "X":
                        playerTwoXCard = true;
                        break;
                    default:
                        playerTwoGamePoints += 12 - int.Parse(playerTwoCard);
                        break;
                }
            }
            
            if (playerOneXCard && playerTwoXCard)
            {
                playerOneMatchScore += 50;
                playerTwoMatchScore += 50;
                playerOneXCard = false;
                playerTwoXCard = false;
            }
            else if (playerOneXCard)
            {
                break;
            }
            else if (playerTwoXCard)
            {                
                break;
            }
            if (playerOneGamePoints > playerTwoGamePoints)
            {
                playerOneMatchScore += playerOneGamePoints;
                playerOneGames++;
            }
            else if (playerOneGamePoints < playerTwoGamePoints)
            {                
                playerTwoMatchScore += playerTwoGamePoints;
                playerTwoGames++;
            }            
        }

        if (playerOneXCard)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (playerTwoXCard)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (playerOneMatchScore > playerTwoMatchScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", playerOneMatchScore);
            Console.WriteLine("Games won: {0}", playerOneGames);
        }
        else if (playerOneMatchScore < playerTwoMatchScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", playerTwoMatchScore);
            Console.WriteLine("Games won: {0}", playerTwoGames);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", playerTwoMatchScore);
        }
    }
}