using System;
class SumOfNAndX
{
    static void Main()
    {
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X= ");
        int x = int.Parse(Console.ReadLine());
        int s = 0;
        int factorialI = 1;
        for (int i = 1; i <= n; i++)
        {  
            factorialI *= i;
            s += factorialI/(int)Math.Pow(x, i);
        }
        Console.WriteLine(s+1);
    }
}