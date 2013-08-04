using System;
class Program
{
    static void Main()
    {
        Console.Write("Employee first name:");
        string firstName = Console.ReadLine();
        Console.Write("Employee family name:");
        string lastName = Console.ReadLine();
        Console.Write("Employee age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Employee gender:");
        string gender = Console.ReadLine();
        Console.Write("Employee unique number:2756");
        int num = int.Parse(Console.ReadLine());
        num = 2756000 + num;
        Console.WriteLine("{0} {1} {2} {3} {4}",firstName,lastName,age,gender,num);
    }
}
