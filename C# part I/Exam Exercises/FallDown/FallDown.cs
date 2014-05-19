using System;

class FallDown
{
    static void Main()
    {
        byte[] bytes = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            bytes[i] = byte.Parse(Console.ReadLine());
        }

        byte[] bitscount = new byte[8];
        byte[] newBytes = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if ((bytes[i] & (1 << j))!=0)
                {
                    bitscount[j]++;
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (bitscount[j] > 0)
                {
                    newBytes[i] = (byte)(newBytes[i] | 1 << j);
                    bitscount[j]--;
                }
            }
        }
        for (int i = 7; i >= 0; i--)
        {
            Console.WriteLine(newBytes[i]);
        }
    }
}