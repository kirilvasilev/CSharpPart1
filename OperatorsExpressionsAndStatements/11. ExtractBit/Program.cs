using System;
class Program
{
    static void Main()
    {
        Console.Write("Your number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Bit number: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int nAndMask = i & mask;
        int bit = nAndMask >> b;
        Console.WriteLine("The value of the bit at position {0} is: {1}" , b, bit); 
    }
}
