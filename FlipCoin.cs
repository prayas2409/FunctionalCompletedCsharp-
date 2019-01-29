using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class FlipCoin
    {
        /// <summary>
        /// Toss has count to get number of times the coin is tossed
        /// counter counts till number of times coin is tossed
        /// heads is number of timnes head occured
        /// tails is number of times tail occured
        /// perheads is pertage of times head occured
        /// </summary>
        public void Toss()
        {
            int count, counter, heads = 0, perheads = 0;
            Console.WriteLine("Enter the number of the times the coin is tossed");
            count = Utility.IsInteger(Console.ReadLine());
            //object of random class
            
            for (counter = count; counter > 0; counter--)
            {
                //generates the random number between 0 and 1
                
                if (Utility.RandomDoubleGenerator()>0.5) heads++;
            }
            /// testing
            perheads = heads * 100 / count;
            Console.WriteLine("The percent of head is {0}, and percent of Tails are  {1}", perheads, 100 - perheads);
        }
    }
}
