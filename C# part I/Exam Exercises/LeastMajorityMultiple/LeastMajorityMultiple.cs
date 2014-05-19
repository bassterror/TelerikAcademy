using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());
        byte c = byte.Parse(Console.ReadLine());
        byte d = byte.Parse(Console.ReadLine());
        byte e = byte.Parse(Console.ReadLine());
        int lmm = int.MaxValue;

        for (int i = 1; i <= 970200; i++)
        {
            if (i % a == 0 && i % b == 0 && i % c == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % a == 0 && i % b == 0 && i % d == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % a == 0 && i % b == 0 && i % e == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % a == 0 && i % c == 0 && i % d == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % a == 0 && i % c == 0 && i % e == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % a == 0 && i % d == 0 && i % e == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % b == 0 && i % c == 0 && i % d == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % b == 0 && i % c == 0 && i % e == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % b == 0 && i % d == 0 && i % e == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (i % c == 0 && i % d == 0 && i % e == 0)
            {
                if (i < lmm)
                {
                    lmm = i;
                }
            }
            if (lmm != int.MaxValue)
            {
                Console.WriteLine(lmm);
                break;
            }
        }
    }
}
