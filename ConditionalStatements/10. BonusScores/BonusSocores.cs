using System;
class BonusSocores
{
    public static ushort cases;
    static void Main()
    {
        Console.Write("Enter a number [1..9]: ");
        ushort score = ushort.Parse(Console.ReadLine());

        if (score >= 1 && score <= 3)
        {
            cases = 1;            
        }
        else if (score >=4 && score <= 6)
        {
            cases = 2;         
        }
        else if (score >= 7 && score <= 9)
        {
            cases = 3;            
        }

        switch (cases)
        {
            case 1:
                Console.WriteLine(score * 10);
                break;
            case 2:
                Console.WriteLine(score * 100);
                break;
            case 3:
                Console.WriteLine(score * 1000);
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}