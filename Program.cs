using System;

namespace SOLIDPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Application");

            Person person = new Person();
            System.Console.WriteLine("What is Your First Name");
            person.FirstName = Console.ReadLine();
            System.Console.WriteLine("What is Your Last Name");
            person.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                System.Console.WriteLine("You Didn't enter a valid First Name");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                System.Console.WriteLine("You Didn't enter a valid Last Name");
                Console.ReadLine();
                return;
            }

            //Create a person
            System.Console.WriteLine($"Your User Name is{person.FirstName.Substring(0,1)}, {person.LastName}");

        }
    }
}
