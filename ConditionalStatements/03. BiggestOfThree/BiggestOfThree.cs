using System;
class BiggestOfThree
{
    static void Main()
    {
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int numThree = int.Parse(Console.ReadLine());
        int big = numOne;

        if (numOne < numTwo)
        {
            big = numTwo;
        }
        if (numTwo < numThree)
        {
            big = numThree;
        }
        Console.WriteLine("The Biggest number is : {0}",big);
    }
}