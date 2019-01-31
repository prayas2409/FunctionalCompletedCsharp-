// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Permutations.cs" company="Bridgelabz">
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
    /// The class is to execute the permutation of string
    /// </summary>
    public class Permutations
    {
        /// <summary>
        /// The method to get the input string
        /// </summary>
        public void StringPermutations()
        {
            try
            {
                string var;
                int i;
                Console.WriteLine("Enter the string to find the permutations");
                var = Utility.IsString(Console.ReadLine());
                for (i = 0; i < var.Length; i++)
                {
                    Console.WriteLine("For {0} ", var[i]);
                    this.Permute(var[i].ToString(), var.Remove(i, 1));
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Permutes given string
        /// </summary>
        /// <param name="upto">The string that has been broken till now</param>
        /// <param name="remaining">The remaining string when a character is taken out from original string</param>
        public void Permute(string upto, string remaining)
        {
            if (remaining.Length == 0)
            {
                Console.Write("{0} ", upto);
            }
            else
            {
                int i = 0;
                string temp1 = upto, temp2 = remaining;
                while (i < remaining.Length)
                {
                    upto = upto + remaining[i];
                    remaining = remaining.Remove(i, 1);
                    this.Permute(upto, remaining);
                    upto = temp1;
                    remaining = temp2;
                    i++;
                }
            }
        }
    }
}
