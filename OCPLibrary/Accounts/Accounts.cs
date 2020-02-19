using System;

namespace OCPLibrary
{
    public class Accounts : IAccounts
    {
        public IEmployeeModel Create(IApplicantModel person)
        {
            IEmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.FirstName = person.LastName + "@YeshuHappyHours.com";
            output.Salary = 20;
            return output;
        }
    }
}

