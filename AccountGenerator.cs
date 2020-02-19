namespace SOLIDPrinciple
{
    public class AccountGenerator
    {

        public static void CreateAccount(Person person)
        {
            System.Console.WriteLine($"Your User Name is{person.FirstName.Substring(0, 1)}, {person.LastName}");
        }
    }
}