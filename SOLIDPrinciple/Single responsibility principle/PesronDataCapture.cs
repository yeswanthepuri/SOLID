using System;

namespace SOLIDPrinciple
{
    public class PesronDataCapture
    {
        public static Person Capture()
        {
            Person outPut = new Person();
            System.Console.WriteLine("What is Your First Name");
            outPut.FirstName = Console.ReadLine();
            System.Console.WriteLine("What is Your Last Name");
            outPut.LastName = Console.ReadLine();
            return outPut;
        }
    }
}