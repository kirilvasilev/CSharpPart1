using System;
class SortValuesInDescendingOrder
{
    static void Main()
    {
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int numThree = int.Parse(Console.ReadLine());
        int first = 0, second = 0, third = 0;

        first = Math.Max(numOne, numTwo);
        first = Math.Max(first, numThree);
        third = Math.Min(numOne, numTwo);
        third = Math.Min(third, numThree);

        if (numOne == first)
        {
            if (numTwo == third)
            {
                second = numThree;
            }
        }
        if (numOne == third)
        {
            if (numTwo== first)
            {
                second = numThree;
            }
        }
        if (numOne == first)
        {
            if (numThree == third)
            {
                second = numTwo;
            }
        }
        if (numOne == third)
        {
            if (numThree == first)
            {
                second = numTwo;
            }
        }
        if (numTwo == first)
        {
            if (numThree == third)
            {
                second = numOne;
            }
        }
        if (numTwo == third)
        {
            if (numThree == first)
            {
                second = numOne;
            }
        }
        
        Console.WriteLine("{0} {1} {2}",first,second,third);
        
    }
}