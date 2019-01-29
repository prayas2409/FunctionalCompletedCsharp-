using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Harmonic
    {
        public void NHarmonic()
        {
            int num, count = 0, numerator = 0, denominator = 1;

            Console.WriteLine("Enter the number to find the Nth Harmonic value");
            num = Utility.IsInteger(Console.ReadLine());
            ////to check if the entered value is number
            //// Multiplying denominators
            for (count = 1; count <= num; count++) denominator = denominator * count;

            for (count = 1; count <= num; count++)
            {
                ////calculating numerator for harmonic 
                numerator += denominator / count;
            }
            Console.WriteLine("The {0}th harmonic number is {1} / {2} or {3} ", num, numerator, denominator, numerator * 1.0 / denominator);
        }
    }
}
