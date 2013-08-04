using System;
class Program
{
    static void Main()
    {
        bool isFemale;
        Console.Write("Enter your gender (male/female):");
        string gender = Console.ReadLine();
        if (gender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("Are you female: " + isFemale);
    }
}
