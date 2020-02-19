using System;

namespace SOLIDPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            var person = PesronDataCapture.Capture();
            bool isValid = PersonValidate.Validate(person);
            if (isValid)
            {
                StandardMessages.EndApplication();
                return;
            }
            //Create a person
            AccountGenerator.CreateAccount(person);
            StandardMessages.EndApplication();
        }

    }
}
