using System;
class CompanyInformation
{
    static void Main()
    {
        //Read company information.

        Console.Write("Company name: ");
        string name = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
         Console.Write("Company phone number: ");
        int phone = int.Parse(Console.ReadLine());
         Console.Write("Company fax number: ");
        int fax = int.Parse(Console.ReadLine());
         Console.Write("Company website: ");
        string web = Console.ReadLine();
         Console.Write("Manager's first name: ");
        string managerFirstName = Console.ReadLine();
         Console.Write("Manager's last name: ");
        string managerLastName = Console.ReadLine();
         Console.Write("Manager's age: ");
        ushort managerAge = ushort.Parse(Console.ReadLine());
         Console.Write("Manager's phone number:");
        int managerNumber = int.Parse(Console.ReadLine());

        //Print company information.

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",name,address,phone,fax,web,managerFirstName,managerLastName,managerAge,managerNumber);
    }
}