using System;
class Program
{
    static void Main()
    {
        decimal pointX;
        Console.Write("Point X position: ");
        pointX = decimal.Parse(Console.ReadLine());
        decimal pointY;
        Console.Write("Point Y position: ");
        pointY = decimal.Parse(Console.ReadLine());
        decimal centerX = 0;
        decimal centerY = 5;

        decimal resultX = (pointX - centerX)
            * (pointX - centerX);
        decimal resultY = (pointY - centerY)
            * (pointY - centerY);

        decimal endResult = resultX + resultY;

        decimal radius = 5;

        bool isWithinCircle = endResult <
            radius * radius;

        Console.WriteLine("Point is within the circle: {0}",isWithinCircle);
    }
}