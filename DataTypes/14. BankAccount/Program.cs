using System;
class Program
{
    static void Main()
    {
        Console.Write("Employee first name:");
        string firstName = Console.ReadLine();
        Console.Write("Employee middle name:");
        string middleName = Console.ReadLine();
        Console.Write("Employee last name:");
        string lastName = Console.ReadLine();
        Console.Write("Avalable amount of money:");
        double balance = double.Parse(Console.ReadLine());
        Console.Write("Bank name:");
        string bankName = Console.ReadLine();
        Console.Write("IBAN:");
        string iban = Console.ReadLine();
        Console.Write("BIC code:");
        string bicCode = Console.ReadLine();
        Console.Write("Credit card number one:");
        ushort numOne = ushort.Parse (Console.ReadLine());
        Console.Write("Credit card number tow:");
        ushort numTwo = ushort.Parse(Console.ReadLine());
        Console.Write("Credit card number three:");
        ushort numThree = ushort.Parse(Console.ReadLine());
        Console.WriteLine("First name:{0}\nMiddle name:{1}\nLast name:{2}\nAvalable amount money:{3}\nBank name:{4}\nIBAN:{5}\nBIC code:{6}\nCredit card number one:{7}\nCredit card number two:{8}\nCredit card number three:{9}\n", firstName, middleName, lastName, balance, bankName, iban, bicCode, numOne, numTwo, numThree);
    }
}
