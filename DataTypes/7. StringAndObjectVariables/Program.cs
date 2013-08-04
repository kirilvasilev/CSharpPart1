using System;
class Program
{
    static void Main()
    {
        string helloStr = "Hello";
        string WorldStr = "World!";
        object concatenation = helloStr + " " + WorldStr;
        string casting = (string) concatenation;
        Console.WriteLine(casting);
    }
}