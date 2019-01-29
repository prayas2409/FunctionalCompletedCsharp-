using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Quadratic
    {
        public void QuadraticDemo()
        {
            int a, b, c, delta;
            double root1, root2;
            Console.WriteLine("Expression ax^2+bx+c=0 ");
            Console.WriteLine("Enter the value of a");
            a = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            c = Utility.IsInteger(Console.ReadLine());
            delta = b * b - 4 * a * c;
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
                Console.WriteLine("Root 1 is : {0}" ,root1);
                Console.WriteLine("Root 2 is : {0}", root2);
            }
        }
    }
}
