using System;

namespace OCPLibrary
{
    public class ExecutiveModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
        public IAccounts AccountProcessor { get; set; } =new ExecutiveAccount();
    }
}
