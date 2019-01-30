// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class is to execute the Leap year program
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// This method checks if the year is leap year
        /// </summary>
        public void Leap()
        {
            int year;
            Console.WriteLine("Enter the year to check if it is leap year");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please try entering value again again");
                year = Utility.IsInteger(Console.ReadLine());
            }
            ////checks if the number is of 4 digits
            while (year < 999 && year > 10000)
            {
                Console.WriteLine(" The year should be a 4 digit number please try again");
            }

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(" The year is a leap year");
                }
                else
                {
                    Console.WriteLine(" The year is not a leap year");
                }
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
