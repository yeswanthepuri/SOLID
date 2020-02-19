using System;

namespace SOLIDPrinciple
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            System.Console.WriteLine("Welcome to the Application");
        }

        public static void EndApplication()
        {
            System.Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayErrorMessage(string errorMessage)
        {
            System.Console.WriteLine($"You Didn't enter a valid {errorMessage}");
        }
    }
}