using System;

namespace StringPracticeDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");

            //string firstName;
            string firstName = Console.ReadLine();

            //Console.WriteLine("Your name is: " + firstName);

            Console.WriteLine("What is your last name?");

            string lastName = Console.ReadLine();

            Console.WriteLine("Your name is: " + firstName.ToLower() + " " + lastName.ToLower());
            //firstName.ToLower();
        }
    }
}
