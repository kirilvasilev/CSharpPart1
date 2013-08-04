using System;
class IntDoubleStringInput
{
    public static int cases;
    public static int intVariable;
    public static double doubleVariable;
    public static string stringVariable;
    static void Main()
    {
        Console.Write("Enter your choise(int,double,string): ");
        string input = Console.ReadLine();
        

        if (input == "int")
        {
            Console.Write("Enter integer value: ");
            intVariable = int.Parse(Console.ReadLine());
            cases = 1;
        }
        else if (input =="double")
        {
            Console.Write("Enter double value: ");
            doubleVariable = double.Parse(Console.ReadLine());
            cases = 2;
        }
        else if (input == "string")
        {
            Console.Write("Enter string value: ");
            stringVariable = Console.ReadLine();
            cases = 3;
        }

        switch (cases)
        {
            case 1:
                intVariable++;
                Console.WriteLine(intVariable);
                break;
            case 2:
                doubleVariable++;
                Console.WriteLine(doubleVariable);
                break;
            case 3:
                Console.WriteLine(stringVariable + "*");
                break;

            default:
                break;
        }
    }
}