// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArrayTwoDim.cs" company="Bridgelabz">
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
    /// Class to execute Array2d program
    /// </summary>
    public class ArrayTwoDim
    {
        /// <summary>
        /// Executes the program of 2d array
        /// </summary>
        public void Array2D()
        {
            int rows, cols;
            Console.WriteLine("Enter the number of rows and colums");
            try
            {
                rows = Convert.ToInt32(Console.ReadLine());
                cols = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please try again");
                rows = Utility.IsInteger(Console.ReadLine());
                cols = Utility.IsInteger(Console.ReadLine());
            }

                double[,] arr = new double[rows, cols];
                Console.WriteLine("Enter the elements of double array");
                arr = this.FetchDouble2DArray(arr);
                Utility.Print2DArray(arr);
        }

        /// <summary>
        /// Fetches the int2 d array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The integer array after getting data</returns>
        public int[,] FetchInt2DArray(int[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    try
                    {
                        array[rows, cols] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Please try again");
                        array[rows, cols] = Utility.IsInteger(Console.ReadLine());
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Fetches the bool 2 d array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>returns the fetched 2 da boolean array</returns>
        public bool[,] FetchBool2DArray(bool[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    try
                    {
                        array[rows, cols] = Convert.ToBoolean(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine("Please try again");
                        array[rows, cols] = Utility.IsBoolean(Console.ReadLine());
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Fetches the double 2 d array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns> the fetched double array</returns>
        public double[,] FetchDouble2DArray(double[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows, cols] = Utility.IsDouble(Console.ReadLine());
                }
            }

            return array;
        }
    }
}
