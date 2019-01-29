using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class ArrayTwoDim
    {
        public void Array2D()
        {
            int rows, cols;
            Console.WriteLine("Enter the number of rows and colums");
            rows = Utility.IsInteger(Console.ReadLine());
            cols = Utility.IsInteger(Console.ReadLine());
            double[,] arr = new double[rows, cols];
            Console.WriteLine("Enter the elements of double array");
            arr = FetchDouble2DArray(arr);
            Utility.Print2DArray(arr);
           
        }

        public static int[,] FetchInt2DArray(int[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows,cols] = Utility.IsInteger(Console.ReadLine());
                }
            }
            return array;
        }
        public static bool[,] FetchBool2DArray(bool[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows,cols] = Utility.IsBoolean(Console.ReadLine());
                }
            }
            return array;
        }
        public static double[,] FetchDouble2DArray(double[,] array)
        {
            int rows = 0, cols = 0, counter = 0;
            for (; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    counter++;
                    Console.WriteLine("Enter the element {0}", counter);
                    array[rows, cols] = Utility.IsDouble(Console.ReadLine());
                }
            }
            return array;
        }
    }
}
