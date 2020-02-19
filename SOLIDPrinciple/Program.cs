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
            List<PersonModel> application = new List<PersonModel>()
              {
                new PersonModel(){FirstName="Epuri",LastName ="Krithvika"},
                new PersonModel(){FirstName="Garaga",LastName ="Karthikaya"},
                new PersonModel(){FirstName="PottriReddy",LastName ="Avanish"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            Accounts accountProcessing = new Accounts();

            foreach (var person in application)
            {
                employees.Add(accountProcessing.Create(person));
            }

            foreach (var employee in employees)
            {
                System.Console.WriteLine($"{employee.FirstName},{employee.LastName}, {employee.EmailAddress} ");
            }
            StandardMessages.EndApplication();
            #endregion
        }

    }
}
