using System;
class Program
{
    static void Main()
    {
        int position = 4;
        int num ;
        Console.Write("Your number: ");
        num = int.Parse (Console.ReadLine());
        int mask = 1 << position;
        int nAndMask = num & mask;
        int bit = nAndMask >> position;
        Console.WriteLine("Bit at position 3 is: {0}",bit);      
    }
}
