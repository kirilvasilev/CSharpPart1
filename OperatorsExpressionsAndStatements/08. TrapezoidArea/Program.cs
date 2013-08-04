using System;
class Program
{
    static void Main()
    {
        Console.Write("Side A: ");
        int sideA = int.Parse(Console.ReadLine());
        Console.Write("Side B: ");
        int sideB = int.Parse(Console.ReadLine());
        Console.Write("Height: ");
        int height = int.Parse(Console.ReadLine());
        int area = ((sideA + sideB)/2) * height;
        Console.WriteLine("Area of the trapezoid is: {0} square centimeters", area);
    }
}
