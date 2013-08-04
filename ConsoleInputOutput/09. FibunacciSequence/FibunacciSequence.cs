using System;
class FibunacciSequence
{
    public static decimal Fibonacci(int n)
    {
        decimal a = 0;
        decimal b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            decimal temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}