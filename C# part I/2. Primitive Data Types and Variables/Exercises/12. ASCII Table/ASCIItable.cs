using System;

class ASCIItable
{
    static void Main()
    {
        for (int a = 0; a < 128; a++)
        {
            char b = (char)a;
            Console.WriteLine("{0} = {1}", a, b);
        }
    }
}
