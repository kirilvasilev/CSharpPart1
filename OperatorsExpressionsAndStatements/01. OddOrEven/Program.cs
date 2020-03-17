using System;
class Program
{
    static void Main()
    {
        Console.Write("Your number:");
        Console.WriteLine($"Number is {int.Parse(Console.ReadLine()) % 2 == 0 ? 'even': 'odd'}!");
    }
}
