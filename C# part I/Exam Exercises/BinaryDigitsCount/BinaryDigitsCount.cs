using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        short n = short.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            uint number = uint.Parse(Console.ReadLine());

            while (number != 0)
            {
                if ((number & 1) == b)
                {
                    count++;
                }
                number = number >> 1;
            }
            Console.WriteLine(count);
        }
    }
}
