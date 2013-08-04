using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number:");
        float valueOne = float.Parse (Console.ReadLine());
        Console.Write("Enter second number:");
        float valueTwo = float.Parse(Console.ReadLine());
        bool result = valueOne - valueTwo == 0;
        Console.WriteLine("Values are equale:" + result);
    }
}
