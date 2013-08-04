using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args) 
        {
            int a;
            System.Console.WriteLine("Your curent age:");
            a = int.Parse(System.Console.ReadLine()) + 10;
            System.Console.WriteLine("Your age after 10 years will be:" + a);
        }
    }
}
