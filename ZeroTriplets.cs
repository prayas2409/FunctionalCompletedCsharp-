using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class ZeroTriplets
    {
       public void Triplets()
        {
            int[] array = new int[8];
            int i, j, k, counter = 0;

          
          Console.WriteLine("Please enter the values for array of 8 digits");

            for (i = 0; i < 8; i++)
            {
                array[i] = Utility.IsInteger(Console.ReadLine());
            }
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

