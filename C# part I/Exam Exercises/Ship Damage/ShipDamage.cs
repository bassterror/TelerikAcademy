using System;

class ShipDamage
{
    static void Main()
    {
        int shipX1 = int.Parse(Console.ReadLine());
        int shipY1 = int.Parse(Console.ReadLine());
        int shipX2 = int.Parse(Console.ReadLine());
        int shipY2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int c1x = int.Parse(Console.ReadLine());
        int c1y = int.Parse(Console.ReadLine());
        int c2x = int.Parse(Console.ReadLine());
        int c2y = int.Parse(Console.ReadLine());
        int c3x = int.Parse(Console.ReadLine());
        int c3y = int.Parse(Console.ReadLine());

        c1y = 2 * h - c1y;
        c2y = 2 * h - c2y;
        c3y = 2 * h - c3y;

        int shipTop = Math.Max(shipY1, shipY2);
        int shipRight = Math.Max(shipX1, shipX2);
        int shipBottom = Math.Min(shipY1, shipY2);
        int shipLeft = Math.Min(shipX1, shipX2);

        int damage = 0;

        if (c1x > shipLeft && c1x < shipRight && c1y < shipTop && c1y > shipBottom)
        {
            damage = damage + 100;
        }
        if (c2x > shipLeft && c2x < shipRight && c2y < shipTop && c2y > shipBottom)
        {
            damage = damage + 100;
        }
        if (c3x > shipLeft && c3x < shipRight && c3y < shipTop && c3y > shipBottom)
        {
            damage = damage + 100;
        }

        if ((c1x == shipLeft && c1y == shipTop) || (c1x == shipLeft && c1y == shipBottom) || (c1x == shipRight && c1y == shipTop) || (c1x == shipRight && c1y == shipBottom))
        {
            damage = damage + 25;
        }
        if ((c2x == shipLeft && c2y == shipTop) || (c2x == shipLeft && c2y == shipBottom) || (c2x == shipRight && c2y == shipTop) || (c2x == shipRight && c2y == shipBottom))
        {
            damage = damage + 25;
        }
        if ((c3x == shipLeft && c3y == shipTop) || (c3x == shipLeft && c3y == shipBottom) || (c3x == shipRight && c3y == shipTop) || (c3x == shipRight && c3y == shipBottom))
        {
            damage = damage + 25;
        }

        if ((c1x == shipLeft && c1y > shipBottom && c1y < shipTop) || (c1x == shipRight && c1y > shipBottom && c1y < shipTop) || (c1y == shipBottom && c1x > shipLeft && c1x < shipRight) || (c1y == shipTop && c1x > shipLeft && c1x < shipRight))
        {
            damage = damage + 50;
        }
        if ((c2x == shipLeft && c2y > shipBottom && c2y < shipTop) || (c2x == shipRight && c2y > shipBottom && c2y < shipTop) || (c2y == shipBottom && c2x > shipLeft && c2x < shipRight) || (c2y == shipTop && c2x > shipLeft && c2x < shipRight))
        {
            damage = damage + 50;
        }
        if ((c3x == shipLeft && c3y > shipBottom && c3y < shipTop) || (c3x == shipRight && c3y > shipBottom && c3y < shipTop) || (c3y == shipBottom && c3x > shipLeft && c3x < shipRight) || (c3y == shipTop && c3x > shipLeft && c3x < shipRight))
        {
            damage = damage + 50;
        }
        
        Console.WriteLine(damage + "%");
    }
}