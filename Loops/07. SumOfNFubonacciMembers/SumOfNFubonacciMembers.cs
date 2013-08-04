using System;
class SumOfNFubonacciMembers
{
    static void Main()
    {
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sum = 0;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
            sum += b;
        }
        Console.WriteLine((sum-b-a)+1);
    }
}