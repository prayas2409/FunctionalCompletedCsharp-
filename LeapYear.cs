using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class LeapYear
    {
        public void Leap()
        {
            int year;
            Console.WriteLine("Enter the year to check if it is leap year");
            year = Utility.IsInteger(Console.ReadLine());

            while (year < 999 && year > 10000)
            {
                Console.WriteLine(" The year should be a 4 digit number please try again");
            }

            if (year % 100 == 0)
            {
                if (year % 400 == 0) Console.WriteLine(" The year is a leap year");
                else Console.WriteLine(" The year is not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(" The year is a leap year");
            }
            else
            {
                Console.WriteLine(" The year is not a leap year");
            }




        }
    }
}
