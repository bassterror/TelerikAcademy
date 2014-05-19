using System;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
        c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = c10 = 0;

        for (int i = 0; i < n; i++)
        {
            byte a = byte.Parse(Console.ReadLine());
            if (a == 1)
            {
                c1++;
            }
            if (a == 2)
            {
                c2++;
            }
            if (a == 3)
            {
                c3++;
            }
            if (a == 4)
            {
                c4++;
            }
            if (a == 5)
            {
                c5++;
            }
            if (a == 6)
            {
                c6++;
            }
            if (a == 7)
            {
                c7++;
            }
            if (a == 8)
            {
                c8++;
            }
            if (a == 9)
            {
                c9++;
            }
            if (a == 10)
            {
                c10++;
            }
        }

        if (c1 >= c2 && c1 >= c3 && c1 >= c4 && c1 >= c5 && c1 >= c6 && c1 >= c7 && c1 >= c8 && c1 >= c9 && c1 >= c10)
        {
            Console.WriteLine(1);
        }
        else if (c2 >= c1 && c2 >= c3 && c2 >= c4 && c2 >= c5 && c2 >= c6 && c2 >= c7 && c2 >= c8 && c2 >= c9 && c2 >= c10)
        {
            Console.WriteLine(2);
        }
        else if (c3 >= c1 && c3 >= c2 && c3 >= c4 && c3 >= c5 && c3 >= c6 && c3 >= c7 && c3 >= c8 && c3 >= c9 && c3 >= c10)
        {
            Console.WriteLine(3);
        }
        else if (c4 >= c1 && c4 >= c2 && c4 >= c3 && c4 >= c5 && c4 >= c6 && c4 >= c7 && c4 >= c8 && c4 >= c9 && c4 >= c10)
        {
            Console.WriteLine(4);
        }
        else if (c5 >= c1 && c5 >= c2 && c5 >= c3 && c5 >= c4 && c5 >= c6 && c5 >= c7 && c5 >= c8 && c5 >= c9 && c5 >= c10)
        {
            Console.WriteLine(5);
        }
        else if (c6 >= c1 && c6 >= c2 && c6 >= c3 && c6 >= c4 && c6 >= c5 && c6 >= c7 && c6 >= c8 && c6 >= c9 && c6 >= c10)
        {
            Console.WriteLine(6);
        }
        else if (c7 >= c1 && c7 >= c2 && c7 >= c3 && c7 >= c4 && c7 >= c5 && c7 >= c6 && c7 >= c8 && c7 >= c9 && c7 >= c10)
        {
            Console.WriteLine(7);
        }
        else if (c8 >= c1 && c8 >= c2 && c8 >= c3 && c8 >= c4 && c8 >= c5 && c8 >= c6 && c8 >= c7 && c8 >= c9 && c8 >= c10)
        {
            Console.WriteLine(8);
        }
        else if (c9 >= c1 && c9 >= c2 && c9 >= c3 && c9 >= c4 && c9 >= c5 && c9 >= c6 && c9 >= c7 && c9 >= c8 && c9 >= c10)
        {
            Console.WriteLine(9);
        }
        else
        {
            Console.WriteLine(10);
        }
    }
}
