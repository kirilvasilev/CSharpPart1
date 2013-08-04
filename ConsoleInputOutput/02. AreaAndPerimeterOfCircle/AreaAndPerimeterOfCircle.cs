using System;
class AreaAndPerimeterOfCircle
{
    static void Main()
    {
        // Read the radius "r".
        Console.Write("Enter the radius: ");
        int r = int.Parse(Console.ReadLine());

        //Print the area and perimeter of the circle with radius "r".

        double area;
        int perimeter;
        Console.WriteLine("Area= {0:F3}\nPerimeter= {1}",area=Math.PI  * ( r * r ) , perimeter=r*2);
    }
}