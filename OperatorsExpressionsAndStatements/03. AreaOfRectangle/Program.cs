using System;
class Program
{
    static void Main()
    {
        int width,height,result;
        Console.Write("Width: ");
        width = int.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = int.Parse(Console.ReadLine());
        result = width * height;
        Console.WriteLine("Area of the rectangle is: " + result);
    }
}
