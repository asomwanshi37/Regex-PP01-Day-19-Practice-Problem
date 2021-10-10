using System;

namespace Regex_Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1;
            bool result1;

            UC1 Lastname = new UC1();
            Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the Last Name");

            name1 = Console.ReadLine();

            result1 = Lastname.LastNameCheck(name1);
            Console.WriteLine(result1);

        }
    }
}
