using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PowerOfTwo
    {
        public void PowerTwo(int number)
        {
            int count1 = 0, count2 = 0, power = 1;
           // Console.WriteLine("Enter the N to get table of powers of 2 till 2^N");
            //number = Utility.IsInteger(Console.ReadLine());

            for (count2 = 1; count2 <= 10; count2++)
            {
                for (count1 = 1; count1 <= number; count1++)
                {
                    power *= 2;
                    Console.Write(" {0}x{1}={2}", power, count2, power * count2);
                }
                Console.WriteLine();
                power = 1;
            }
        }
    }
}
