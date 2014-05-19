using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n;
        int center = width / 2;

        for (int i = 1; i <= n / 2; i++)
        {
            int pos = 1;
            while (pos <= width)
            {
                if ((pos <= center - i) || (pos > center + i))
                {
                    Console.Write(".");
                    pos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("/");
                            pos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            pos++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("\\");
                            pos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            pos++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        for (int i = n / 2; i > 0; i--)
        {
            int pos = 1;
            while (pos <= width)
            {
                if ((pos <= center - i) || (pos > center + i))
                {
                    Console.Write(".");
                    pos++;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("\\");
                            pos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            pos++;
                        }
                    }
                    for (int j = i; j > 0; j--)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("/");
                            pos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            pos++;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}