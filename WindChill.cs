// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
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
    /// The class is used to execute the wind chill program
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Executes the windchill program
        /// </summary>
        /// <param name="t">The T is temperature in Fahrenheit.</param>
        /// <param name="v">The v is the speed of winds in miles per hour.</param>
        public void WindChillDemo(double t, double v)
        {
            try
            {
                double w;
                w = 35.74 + (0.6215 * t) + (((0.4275 * t) - 35.75) * Math.Pow(v, 0.16));
                Console.WriteLine("W= " + w + " and v= " + v);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
