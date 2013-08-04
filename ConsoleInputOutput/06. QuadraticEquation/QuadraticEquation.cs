using System;
class QuadraticEquation
{
    static void Main()
    {
        //Reads the parameters of the quadratic equation
        
        double a, b, c,x,x1,x2,img,sqrtpart;
        Console.Write("Enter paraemter a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter parameter b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Enter parameter c: ");
        c = double.Parse(Console.ReadLine());
        
        //Calculates the descriminant
        
        sqrtpart = b * b - 4 * a * c;

        //Checks what solution the quadratic equation has
        
        if (sqrtpart > 0)
        {
            x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
        }
        else if (sqrtpart < 0)
        {
            sqrtpart = -sqrtpart;
            x = -b / (2 * a);
            img = System.Math.Sqrt(sqrtpart) / (2 * a);
            Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
        }
        else
        {
            x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("One Real Solution: {0,8:f4}", x);
        }
    }
}