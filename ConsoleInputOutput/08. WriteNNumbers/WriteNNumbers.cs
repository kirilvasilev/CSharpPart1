using System;
class WriteNNumbers
{
    public static int n;
    static void Main()
    {
        //Cycle that prints N given numbers
        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n+1; i++)
        {
            Console.WriteLine(i);
        }
    }
}