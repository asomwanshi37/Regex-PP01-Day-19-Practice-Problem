using System;

namespace Regex_Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool result;

            UC1 firstname = new UC1();
            Console.WriteLine("Enter First Character in Bolt Latters...");
            Console.WriteLine("Enter the First Name");

            name1 = Console.ReadLine();

            result = firstname.FirstNameCheck(name);
            Console.WriteLine(result);

        }
    }
}
