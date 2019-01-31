// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Harmonic.cs" company="Bridgelabz">
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
    /// The class is to execute the Harmonic number program
    /// </summary>
    public class Harmonic
    {
        /// <summary>
        /// Executes the harmonic functions
        /// </summary>
        public void NHarmonic()
        {
            try
            {
                int num, count = 0, numerator = 0, denominator = 1;

                Console.WriteLine("Enter the number to find the Nth Harmonic value");
                num = Utility.IsInteger(Console.ReadLine());
                //// to check if the entered value is number
                //// Multiplying denominators
                for (count = 1; count <= num; count++)
                {
                    denominator = denominator * count;
                }
                ////calculating numerator for harmonic 
                for (count = 1; count <= num; count++)
                {
                    numerator += denominator / count;
                }

                Console.WriteLine("The {0}th harmonic number is {1} / {2} or {3} ", num, numerator, denominator, numerator * 1.0 / denominator);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
