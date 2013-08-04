using System;
class NumberBetweenTwoNumbers
{
    public static int p = 0;
    static void Main()
    {
        //Reads two positiv integer numbers

        Console.Write("First number: ");
        uint numOne = uint.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        uint numTwo = uint.Parse(Console.ReadLine());

        //Cycle that checks if any number between the given two positive integers is divided by 5 with no remainder and increas p by 1

        for (uint i = numOne; i <= numTwo ; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }

        Console.WriteLine("p({0},{1})={2}",numOne,numTwo,p);
    }
}