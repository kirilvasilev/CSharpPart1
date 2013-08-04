using System;
class Program
{
    static void Main()
    {
        int number;
        Console.Write("Write your number: ");
        number = int.Parse(Console.ReadLine());
        bool isSeven = (number / 100) % 10 == 7;
        Console.WriteLine("Third digit is 7:{0}",isSeven);
    }
}
