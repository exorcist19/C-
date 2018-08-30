using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentInformation
{
    public class StudentInformation
    {
        public static void Main()
        {
            StudentInfo Mike = new StudentInfo();
            Console.WriteLine("Name: " + Mike.FirstName + " " + Mike.LastName + "\n" + "GPA: ");
            Console.ReadLine();
        }
    }
}