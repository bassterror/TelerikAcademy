using System;

class BatGoikoTower
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int width = h * 2;
        int center = h;
        int power = 1;
        int firstRowSideDots = (width - 2) / 2;

        Console.Write(new string('.', firstRowSideDots));
        Console.Write("/\\");
        Console.Write(new string('.', firstRowSideDots));
        Console.WriteLine();

        for (int i = 2; i <= h; i++)
        {
            if (i == 2 || i == 4 || i == 7 || i == 11 || i == 16 || i == 22 || i == 29 || i == 37)
            {
                int sideDots = h - i;
                int mid = 2 * power;
                Console.Write(new string('.', sideDots));
                Console.Write('/');
                Console.Write(new string('-', mid));
                Console.Write('\\');
                Console.Write(new string('.', sideDots));
                Console.WriteLine();
                power++;            
            }
            else
            {
                int sideDots = h - i;
                int mid = 2 * power;
                Console.Write(new string('.', sideDots));
                Console.Write('/');
                Console.Write(new string('.', mid));
                Console.Write('\\');
                Console.Write(new string('.', sideDots));
                Console.WriteLine();
                power++;            

            }
        }
    }
}