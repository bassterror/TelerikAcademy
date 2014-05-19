// We are given integer number n, value v (v=0 or 1) and a position p. 
// Write a sequence of operators that modifies n to hold the value v 
// at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class SetBitValue
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value (1 or 0): ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        
        if (v == 0)
        {
            int mask = ~(1 << p);
            int a = n & mask;
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
            Console.WriteLine("Wich is {0} in decimal system.", a);
        }
        else if (v == 1)
        {
            int mask = (1 << p);
            int b = n | mask;
            Console.WriteLine(Convert.ToString(b, 2).PadLeft(16, '0'));
            Console.WriteLine("Wich is {0} in decimal system.", b);
        }
        else
        {
            Console.WriteLine("Not working!");
        }
    }
}
