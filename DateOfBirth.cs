using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_ATM
{
    public class DateOfBirth
    {
        int day;
        string month;
        int year;

        public DateOfBirth(int day, string month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        //getters for cardHolder
        public int getDay()
        {
            return day;
        }

        public string getMonth()
        {
            return getMonth;
        }

        public int getYear()
        {
            return getYear;
        }
        
        //setters for cardHolder
        public void setDay(int newDay)
        {
            day = newDay;
        }

        public void setMonth(string newMonth)
        {
            month = newMonth;
        }

        public void setYear(int newYear)
        {
            year = newYear;
        }        
    }
}
