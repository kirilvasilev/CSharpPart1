using System;
class CalculateSum
{
    public static float a = 1;
    static void Main()
    {
        float n = float.Parse(Console.ReadLine());
     
        //Cycle that adds the divided N number
        
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("{0:F3}",a = a + (1 / n));

        }
    }
}