using System;

namespace StringPracticeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");

            string firstName = Console.ReadLine();
            int firstLength = firstName.Length;

            Console.WriteLine("What is your last name?");

            string lastName = Console.ReadLine();
            int lastLength = lastName.Length;

            Console.WriteLine("Your name is: " + firstName.ToUpper() + " " + lastName.ToLower());
            if(firstLength >= lastLength)
            {
                Console.WriteLine(firstName);
            }

            if(lastLength >= firstLength)
            {
                Console.WriteLine(lastName);
            }

            Console.WriteLine("Your first name is " + firstLength + " letters long");
            Console.WriteLine("Your last name is " + lastLength + " letters long");
        }
    }
}
