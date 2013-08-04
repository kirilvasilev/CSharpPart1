using System;
class Program
{
    static void Main()
    {
        int valueOne = 5;
        int valueTwo = 10;
        Console.WriteLine("Before exchange value one is {0} and value two is {1}.",valueOne,valueTwo);
        int change = valueOne;
        valueOne = valueTwo;
        valueTwo = change;
        Console.WriteLine("After exchange value one is {0} and value two is {1}.", valueOne, valueTwo);
    }
}
