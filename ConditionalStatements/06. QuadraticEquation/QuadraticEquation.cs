using System;
class QuadraticEquation
{
    public static double a, b, c, x1, x2;
    static void Main()
    {
        Console.Write("A=");
        a = double.Parse(Console.ReadLine());
        Console.Write("B=");
        b = double.Parse(Console.ReadLine());
        Console.Write("C=");
        c = double.Parse(Console.ReadLine());
         
        //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

        //Calculate the inside of the square root
        double insideSquareRoot = (b * b) - 4 * a * c;
        Console.WriteLine("Descreminant = {0}", insideSquareRoot);

        if (insideSquareRoot < 0)
        {
            //There is no solution
            x1 = double.NaN;
            x2 = double.NaN;
            Console.WriteLine("There is no solution");
        }
        else
        {
            //Compute the value of each x
            //if there is only one solution, both x's will be the same
            double sqrt = Math.Sqrt(insideSquareRoot);
            x1 = (-b + sqrt) / (2 * a);
            x2 = (-b - sqrt) / (2 * a);
            if (x1 == x2)
            {
                Console.WriteLine("There is only one sollution: {0}", x1);
            }
            else
            {
                Console.WriteLine("There are two solutions: \nX1={0} \nX2={1}", x1, x2);
            }
        }
    }
}