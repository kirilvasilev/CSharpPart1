using System;
class DivisionOfNK
{
    static void Main()
    {
        Console.Write("N(N>K)= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K(K>1)= ");
        int k = int.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        if (k < 1 || n < k)
        {
            Console.WriteLine("K is smaller than 1 or N is smaller  than K");
        }
        else
        {
            while (true)
            {
                if (n == 1)
                {
                    break;
                }
                factorialN *= n;
                n--;
            }
            while (true)
            {
                if (k == 1)
                {
                    break;
                }
                factorialK *= k;
                k--;
            }
            Console.WriteLine(factorialN / factorialK);
        }
       
    }
}