
using System;
class MinAndMaxFromNNumbers
{
    static void Main()
    {
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 1; i <=n; i++)
        {
            Console.Write("Enter number ");
            int num = int.Parse(Console.ReadLine());
            if (num  >  max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("Min= {0}",min);
        Console.WriteLine("Max= {0}",max);
    }
}