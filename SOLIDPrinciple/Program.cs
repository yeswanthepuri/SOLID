using OCPLibrary;
using System.Collections;
using System.Collections.Generic;

namespace SOLIDPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region S- Single Responsibility Principle
            // StandardMessages.WelcomeMessage();
            // var person = PesronDataCapture.Capture();
            // bool isValid = PersonValidate.Validate(person);
            // if (isValid)
            // {
            //     StandardMessages.EndApplication();
            //     return;
            // }
            // //Create a person
            // AccountGenerator.CreateAccount(person);
            // StandardMessages.EndApplication();
            #endregion
            #region O - Open Close Principle
            List<IApplicantModel> application = new List<IApplicantModel>()
              {
                new ExecutiveModel(){FirstName="Epuri",LastName ="Krithvika"},
                new ManagerModel(){FirstName="Garaga",LastName ="Karthikaya"},
                new PersonModel(){FirstName="PottriReddy",LastName ="Avanish"},
            };

            List<IEmployeeModel> employees = new List<IEmployeeModel>();

            foreach (var person in application)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                System.Console.WriteLine
                ($"{employee.FirstName},\t{employee.LastName}, \t{employee.EmailAddress}, \t{employee.IsManager},\t{employee.IsExecutive},\t{employee.Salary} ");
            }
            StandardMessages.EndApplication();
            #endregion
        }

    }
}
