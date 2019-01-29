using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public void WindChillDemo(double t, double v)
        {
            double w;
            //w=(0.4275*t)-35.75;
            //v=Math.pow(v,0.16);
            w = 35.74 + 0.6215 * t + ((0.4275 * t) - 35.75) * (Math.Pow(v, 0.16));
            Console.WriteLine("W= " + w + " and v= " + v);

        }
    }
}
