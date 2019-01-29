using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        /// <summary>
        ///  IsInteger Determines whether the specified input is integer.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is integer; otherwise, <c>false</c>.
        /// </returns>
        public static int IsInteger(String input)
        {
            int num;
            if (Int32.TryParse(input, out num)) return Convert.ToInt32(input);
            else
            {
                while (Int32.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered an integer number please try again");
                    input = Console.ReadLine();
                }
                return Convert.ToInt32(input);
            }
        }
        public static double IsDouble(String input)
        {
            double num;
            if (Double.TryParse(input, out num)) return num;
            else
            {
                while (Double.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered a number please try again");
                    input = Console.ReadLine();
                }
                return num;
            }
        }
        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <c>true</c> if the specified input is not having a number and any spaces; otherwise, <c>false</c>.
        /// </returns>
        public static string IsString(String input)
        {
            int flag = 1;
            do
            {
                int i = 0;
                if (input.Contains(" "))
                {
                    flag = 1;
                    Console.WriteLine("You have entered space it should not be, please try again");
                    input = Console.ReadLine();
                }
                // it checks it the string has spaces
                for (i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("You have entered number in string it should not be please try again");
                        input = Console.ReadLine();
                        break;
                    }
                    else flag = 0;
                }
            } while (flag == 1);
            return input;
        }
        /// <summary>Determines whether the specified input is boolean.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.</returns>

        public static bool IsBoolean(String input)
        {
            input.ToLower();
            ////this check the value of input if its true or false
            while(String.Equals(input,"true")!=true && String.Equals(input,"false")!= true)
            {
                input.ToLower();
                Console.WriteLine("You have not entered a boolean value please try again");
                input = Console.ReadLine();
            }
            return input.Equals("true") ? true : false;
        }
        public static void Print2DArray<Template>(Template[,] array)
        {
            int rows = 0, cols = 0;
            for (rows = 0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows,cols]);

                }
                Console.WriteLine();
            }
        }
        public static double RandomDoubleGenerator()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }
        public static int RandomIntGenerator(int min,int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

    }
}
