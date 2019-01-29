using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PrimeFactors
    {
        public void PrimeFactorsfor()
        {

            int number, counter2 = 2, counter = 2, flag = 0, flag1 = 0;
            Console.WriteLine("Please enter the value to get the prime factors");
            number = Utility.IsInteger(Console.ReadLine());

            for (counter = 2; (counter * counter) <= number; counter++)
            {
                if (number % counter == 0)
                {
                    for (counter2 = 2; counter2 <= (counter / 2); counter2++)
                    {
                        //if counter is  not prime
                        if (counter % counter2 == 0)
                        {
                            flag = 1;
                            break;
                        }

                    }
                    if (flag == 0)
                    {
                        Console.Write("{0} ", counter);
                        flag1 = 1;
                    }
                    flag = 0;
                }
            }
            if (flag1 == 0)
            {
                Console.WriteLine("The number itself is prime number");
            }

        }
    }
}
