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
            output.FirstName = person.LastName + "@YeshuHappyHours.com";

           switch (person.TypeOfEmployee)
           {
               //This is the code that is working in production and will no longer work because we missed to add the logic back.
               case EmployeeType.Executive :
               break;
               
               case EmployeeType.Manager :
               output.IsManager =true;
               break;
           }
            return output;
        }
    }
}

