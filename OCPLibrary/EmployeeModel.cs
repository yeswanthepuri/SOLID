using System;

namespace OCPLibrary
{
    public class EmployeeModel : IEmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; }
        public bool IsExecutive { get; set; }
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value + 10;
            }
        }

    }
}

