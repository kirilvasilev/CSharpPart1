using System;
class Program
{
    static void Main()
    {
        int numOne;
        Console.Write("Your number:");
        numOne = int.Parse(Console.ReadLine());
        if (numOne % 2 == 0) 
        {
            Console.WriteLine("Number is even!");
        }
        else
        {
            Console.WriteLine("Number is odd!");
        }
    }
}
