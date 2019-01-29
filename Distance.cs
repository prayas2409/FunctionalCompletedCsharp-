using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public void SqrtDistance()
        {
            int x, y;
            Console.WriteLine("Enter the value of x and y");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            double dist;
            dist = Math.Sqrt(x * x + y * y);
            Console.WriteLine("Distance is {0}",dist);
        }
    }
}
