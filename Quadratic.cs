// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class has functions to find the square roots of the equations
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// method to execute the Quadratic roots programs
        /// </summary>
        public void QuadraticDemo()
        {
            //// a, b, c are the varaibles that store the values of expression to find the roots
            int a, b, c, delta;
            //// holds value of roots
            double root1, root2;
            Console.WriteLine("Expression ax^2+bx+c=0 ");
            Console.WriteLine("Enter the value of a");
            a = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            c = Utility.IsInteger(Console.ReadLine());
            delta = (b * b) - (4 * (a * c));
            ////if delta is negetive it gives imaginary roots
            if (delta < 0)
            {
                root1 = -b / 2 * a;
                root2 = -b / 2 * a;
                delta = -delta;
                Console.WriteLine("Root 1 is : {0} + {1}i", root1, Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("Root 2 is : {0} - {1}i", root1, Math.Sqrt(delta) / 2 * a);
            }
            else
            {
                root1 = (-b / 2 * a) - (Math.Sqrt(delta) / 2 * a);
                root2 = (-b / 2 * a) + (Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("Root 1 is : {0}", root1);
                Console.WriteLine("Root 2 is : {0}", root2);
            }
        }
    }
}
