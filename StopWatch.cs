using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class StopWatch
    {
        public void StopWatchDemo()
        {
           int start, stop;
            start = DateTime.Now.Second;
           Console.WriteLine("Timer started: please press enter to stop ");
            Console.ReadLine();
            stop = DateTime.Now.Second;
            Console.WriteLine("Elapsed time in seconds {0} ", stop - start);
        }
    }
}
