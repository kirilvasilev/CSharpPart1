using System;
class ProductOfThreeNumbers
{
    static void Main()
    {
        Console.Write("First number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int numThree = int.Parse(Console.ReadLine());
        int positive = 0, negative = 0, zero = 0;

        if (numOne < 0)
        {
            negative++;
        }
        else if (numOne > 0)
        {
            positive++;
        }
        else if (numOne == 0)
        {
            zero++;
        }
        if (numTwo < 0)
        {
            negative++;
        }
        else if (numTwo > 0)
        {
            positive++;
        }
        else if (numTwo == 0)
        {
            zero++;
        }
        if (numThree < 0)
        {
            negative++;
        }
        else if (numThree > 0)
        {
            positive++;
        }
        else if (numThree == 0)
        {
            zero++;
        }
        if (zero > 0)
        {
            Console.WriteLine("0");
            return;
        }
        if (positive == 3)
        {
            Console.WriteLine("+");
        }
        if (negative == 1)
        {
            Console.WriteLine("-");
        }
        if (negative == 2)
        {
            Console.WriteLine("+");
        }
        if (negative == 3)
        {
            Console.WriteLine("-");
        }
    }
}