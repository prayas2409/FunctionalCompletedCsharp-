// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
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
    /// this class finds distance between 2 co=ordinates
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// This method finds the distance.
        /// </summary>
        public void SqrtDistance()
        {
            int x, y;
            Console.WriteLine("Enter the value of x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            double dist;
            dist = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("Distance is {0}", dist);
        }
    }
}
