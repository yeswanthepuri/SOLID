using System;

namespace OCPLibrary
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
        public IAccounts AccountProcessor { get; set; } =new ManagerAccount();
    }
}
