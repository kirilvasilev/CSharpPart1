using System;
public class Program
{
    static void Main()
    {
        int num;
        
Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        bool exp;
        if (num % 5 ==0)
        {
            if (num % 7==0)
            {
                exp = true;
                Console.WriteLine("Number can be divided bt 5 and 7:{0}",exp);
            }
            else
            {
                exp = false;
                Console.WriteLine("Number can be divided bt 5 and 7:{0}",exp);
            }
        }
        else
        {
            exp = false;
            Console.WriteLine("Number can be divided bt 5 and 7:{0}", exp);
        }
    }
}