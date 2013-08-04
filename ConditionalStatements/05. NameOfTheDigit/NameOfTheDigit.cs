using System;
class NameOfTheDigit
{
    static void Main()
    {
        Console.Write("Your digit: ");
        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}