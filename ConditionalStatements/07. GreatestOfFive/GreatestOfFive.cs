using System;
class GreatestOfFive
{
    static void Main()
    {
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int numThree = int.Parse(Console.ReadLine());
        Console.Write("Fourth number: ");
        int numFour = int.Parse(Console.ReadLine());
        Console.Write("Fifth number: ");
        int numFive = int.Parse(Console.ReadLine());

        int big = numOne;

        if (big < numTwo)
        {
            big = numTwo;
        }
        if (big < numThree)
        {
            big = numThree;
        }
        if (big < numFour)
        {
            big = numFour;
        }
        if (big < numFive)
	{
		 big = numFive;
	}
        Console.WriteLine("The Biggest number is : {0}", big);
    }
}