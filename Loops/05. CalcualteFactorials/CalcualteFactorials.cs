using System;
using System.Numerics;
class CalcualteFactorials
{
    static void Main()
    {
        Console.Write("N(N>K)= ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("K(K>1)= ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factKN = 1;
        BigInteger KN = k - n;
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
            while (true)
            {
                if (KN <= 0)
                {
                    break;
                }
                factKN *= KN;
                KN++;
            }
            Console.WriteLine((factorialN * factorialK) / KN);
        }
       
    }
}