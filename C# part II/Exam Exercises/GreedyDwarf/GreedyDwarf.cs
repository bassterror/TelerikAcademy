using System;
using System.Linq;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            string valley = Console.ReadLine();
            int[] valleyArray = valley.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            int m = int.Parse(Console.ReadLine());
            int coinsCollected = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                int currentCoins = 0;
                string pattern = Console.ReadLine();
                int[] patternArray = pattern.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                bool[] visited = new bool[valleyArray.Length];
                int indexPattern = 0;
                int indexValley = 0;
                while (true)
                {
                    if (indexValley > valleyArray.Length - 1 || indexValley < 0)
                    {
                        break;
                    }
                    if (indexPattern == patternArray.Length)
                    {
                        indexPattern = 0;
                    }
                    if (visited[indexValley])
                    {
                        break;
                    }
                    currentCoins += valleyArray[indexValley];
                    visited[indexValley] = true;
                    indexValley += patternArray[indexPattern];
                    indexPattern++;
                }
                if (currentCoins > coinsCollected)
                {
                    coinsCollected = currentCoins;
                }
            }
            Console.WriteLine(coinsCollected);
        }
    }
}