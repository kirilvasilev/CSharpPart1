using System;
class Program
{
    static void Main()
    {
        bool result;
        Console.Write("Your number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = num & mask;
        int bit = nAndMask >> p;
        if (bit==1)
        {
            result = true;
            Console.WriteLine("Value of the bit is 1: {0}", result);
        }
        else
        {
            result = false;
            Console.WriteLine("Value of the bit is 1: {0}", result);
        }
    }
}
