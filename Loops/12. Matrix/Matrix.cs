using System;
class Matrix
{
    static void Main()
    {
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        int temp;
        for (int row = 1; row <= n ; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                temp = col;
                for (int i = 1; i < n; i++)
		        {
                    Console.WriteLine(temp);
                    temp++;
                }
            }
            Console.WriteLine();

        }
    }
}