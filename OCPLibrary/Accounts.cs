using System;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.FirstName = person.LastName+"@YeshuHappyHours.com";
            return output;
        }
    }
}

