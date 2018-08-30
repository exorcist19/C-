using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Q1
{
    class Date
    {
        private int year;
        private int month;
        private int day;
        private string monthName;

        public Date()
        {

        }
        public Date(int Year, int Month, int Day)
        {
            year = Year;
            month = Month;
            day = Day;

        }
        public string returnMonthName(int monthNumber)
        {
            string formattedDate;
            switch (monthNumber)
            {
                case 1: monthName = "January";
                    break;
                case 2: monthName = "February";
                    break;
                case 3: monthName = "March";
                    break;
                case 4: monthName = "April";
                    break;
                case 5: monthName = "May";
                    break;
                case 6: monthName = "June";
                    break;
                case 7: monthName = "July";
                    break;
                case 8: monthName = "August";
                    break;
                case 9: monthName = "September";
                    break;
                case 10: monthName = "October";
                    break;
                case 11: monthName = "November";
                    break;
                case 12: monthName = "December";
                    break;
            }
            formattedDate = monthName + " " + day + ", " + year;
            return formattedDate;
        }
        public override string ToString()
        {
            return month + "/" + day + "/" + year;
        }
    }
}
