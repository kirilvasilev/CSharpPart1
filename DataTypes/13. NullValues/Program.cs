using System;
class Program
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Integer Value:-{0}-, Double Value:-{1}-", nullInt, nullDouble);
        Console.WriteLine("Integer Value increased by 50:-{0}-, Double Value increased by 30:-{1}-", nullInt + 50, nullDouble + 30);
    }
}