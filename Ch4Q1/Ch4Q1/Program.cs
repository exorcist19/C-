using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input Year, Month, Day from user
            //Check validation of Date

            String year;
            String month;
            String day;




            WriteLine("Enter year");
            year = ReadLine();
            WriteLine("Enter month");
            month = ReadLine();
            WriteLine("Enter day");
            day = ReadLine();


            Date MyDate = new Date(int.Parse(year), int.Parse(month), int.Parse(day));
            WriteLine("The Month Name is " + MyDate.returnMonthName(int.Parse(month)));
            WriteLine("The formatted date is " + MyDate.ToString());



            ReadKey();



        }
    }
}
