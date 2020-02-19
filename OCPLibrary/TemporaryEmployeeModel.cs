using System;

namespace OCPLibrary
{
    public class TemporaryEmployeeModel : IEmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsManager { get; set; }
        public bool IsExecutive { get; set; }
        public int Salary { get; set; }
    }
}

