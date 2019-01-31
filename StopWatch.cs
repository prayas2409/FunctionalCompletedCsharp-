// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Text;

    /// <summary>
    /// The class does the stopwatch program
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// Starts automatically takes input and then stops prints time between it
        /// </summary>
        public void StopWatchDemo()
        {
            try
            {
                //// start holds the stating time and stop holding ending time
                int start, stop;
                start = DateTime.Now.Second;
                Console.WriteLine("Timer started: please press enter to stop ");
                Console.ReadLine();
                stop = DateTime.Now.Second;
                Console.WriteLine("Elapsed time in seconds {0} ", stop - start);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
