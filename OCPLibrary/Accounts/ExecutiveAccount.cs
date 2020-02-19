using System;

namespace OCPLibrary
{
    public class ExecutiveAccount : IAccounts
    {
        public IEmployeeModel Create(IApplicantModel person)
        {
            IEmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.IsManager =true;
            output.IsExecutive =true;

            output.FirstName = person.LastName + "@YeshuHappyHours.com";
            return output;
        }
    }
}

