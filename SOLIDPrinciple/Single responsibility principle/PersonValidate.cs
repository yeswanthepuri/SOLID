using System;

namespace SOLIDPrinciple
{
    public class PersonValidate
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayErrorMessage("First Name");
                StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayErrorMessage("Last Name");
                StandardMessages.EndApplication();
                return false;
            }
            return true;
        }
    }
}