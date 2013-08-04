using System;
class GreaterNumberWithoutIF
{
    static void Main()
    {
        //Read two numbers
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());

        //Print the greater number

        int greater;
        Console.WriteLine("The greater number is: {0}",greater = Math.Max(numOne,numTwo));
    }
}
