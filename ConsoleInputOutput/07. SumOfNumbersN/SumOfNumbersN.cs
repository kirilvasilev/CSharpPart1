using System;
class SumOfNumbersN
{
    //State a public variable "sum"
    public static int sum;
    static void Main()
    {

        //Cicle that calculates the sum of the given N number with the privious

        while (true)
        {
            Console.Write("Write your number N: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The sum of {0} and {1} is: {2}",sum,n,sum += n);
        }
    }
}
