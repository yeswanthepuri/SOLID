using System;

namespace OCPLibrary
{
    public class ManagerAccount : IAccounts
    {
        public IEmployeeModel Create(IApplicantModel person)
        {
            IEmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.IsManager =true;
            output.FirstName = person.LastName + "@YeshuHappyHours.com";
            return output;
        }
    }
}

