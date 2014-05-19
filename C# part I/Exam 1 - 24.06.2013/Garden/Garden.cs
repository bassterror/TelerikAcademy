using System;
using System.Threading;
using System.Globalization;

class Garden
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        int tomatoAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucamberAmount = int.Parse(Console.ReadLine());
        int cucamberArea = int.Parse(Console.ReadLine());
        int potatoAmount = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabageAmount = int.Parse(Console.ReadLine());
        int cabageArea = int.Parse(Console.ReadLine());
        int beansAmount = int.Parse(Console.ReadLine());

        decimal tomatoPrice = 0.5m;
        decimal cucamberPrice = 0.4m;
        decimal potatoPrice = 0.25m;
        decimal carrotPrice = 0.6m;
        decimal cabagePrice = 0.3m;
        decimal beansPrice = 0.4m;
        decimal totalPrice = (tomatoAmount * tomatoPrice) + (cucamberAmount * cucamberPrice) + (potatoAmount * potatoPrice) + (carrotAmount * carrotPrice) + (cabageAmount * cabagePrice) + (beansAmount * beansPrice);

        Console.WriteLine("Total costs: {0:F2}", totalPrice);

        int totalArea = 250;
        int remainArea = totalArea - (tomatoArea + cucamberArea + potatoArea + carrotArea + cabageArea);
        if (remainArea > 0)
        {
            Console.WriteLine("Beans area: {0}", remainArea);
        }
        else if (remainArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}