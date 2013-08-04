using System;
class ExchangeVariables
{
    static void Main()
    {
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        if (numOne > numTwo)
        {
            int exchange = numOne;
            numOne = numTwo;
            numTwo = exchange;
        }
        Console.WriteLine();
        Console.WriteLine("The first number is: {0} \n The second number is: {1}",numOne,numTwo);
    }
}