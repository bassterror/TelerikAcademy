using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] num = new long[n];
        for (int i = 0; i < n; i++)
        {
            num[i] = long.Parse(Console.ReadLine());
        }
        Array.Sort(num);

        long temp = 0;
        int oddcount = 1;
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                temp = num[i];
            }
            else
            {
                if (temp == num[i])
                {
                    oddcount++;
                }
                else
                {
                    if (oddcount % 2 == 0)
                    {
                        temp = num[i];
                        oddcount = 1;
                    }
                    else
                    {
                        Console.WriteLine(num[i - 1]);
                        return;
                    }
                }
            }
        }
        Console.WriteLine(num[n - 1]);
    }
}