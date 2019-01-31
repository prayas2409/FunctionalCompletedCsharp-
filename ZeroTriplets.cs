// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ZeroTriplets.cs" company="Bridgelabz">
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
    /// The class executes the Zero triplet program
    /// </summary>
    public class ZeroTriplets
    {
        /// <summary>
        /// The method is executing the 0 triplets program
        /// </summary>
        public void Triplets()
        {
            int[] array = new int[8];
            ////the variable are to traverse the array and counter counts number of triples
            int i, j, k, counter = 0;          
            Console.WriteLine("Please enter the values for array of 8 digits");
            for (i = 0; i < 8; i++)
            {
                array[i] = Utility.IsInteger(Console.ReadLine());
            }
            //// traversing the array to search the triplets
            for (i = 0; i < 6; i++)
            {
                for (j = i + 1; j < 7; j++)
                {
                    for (k = j + 1; k < 8; k++)
                    {
                        if ((array[i] + array[j] + array[k]) == 0)
                        {
                           Console.WriteLine(array[i] + "," + array[j] + "," + array[k]);
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine("The number of triplets are " + counter);
        }
    }
}
