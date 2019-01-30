// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTacToe.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class plays game tic tac toe
    /// </summary>
    public class TicTacToe
    {
        /// <summary>
        /// Values at position.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        /// <returns>it returns the value which is at the position</returns>
        public int ValueAtPosition(int[,] array, int index)
        {
            int j, i = 0, num = 0;
            ////traverse through complete array to check the number at the required position position
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    num++;
                    if (num == index)
                    {
                        return array[i, j];
                    }
                }
            }

            return 1;
        }

        /// <summary>
        /// Enters the number in specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        /// <param name="number">The number.</param>
        /// <returns>returns the resultant array after adding the number to the array</returns>
        public int[,] Enter(int[,] array, int index, int number)
        {
            //// These numbers are traversing till number reaches index and then enters the number
            int i = 0, j = 0, num = 0;

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    num++;
                    if (num == index)
                    {
                        array[i, j] = number;
                        array[i, j] = number;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Checks if end.
        /// </summary>
        /// <param name="a"> the integer array </param>
        /// <returns> 1 if all the elements are either 0 or 1</returns>
        public int CheckIfEnd(int[,] a)
        {
            ////flag stores 0 is any of the element is not 0 or 1
            int i, j, flag = 1;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (a[i, j] == 0 || a[i, j] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("game over");
                return flag;
            }

            return flag;
        }

        /// <summary>
        /// Checks if won.
        /// </summary>
        /// <param name="a"> The first parameter is 2d array</param>
        /// <param name="val"> The value.</param>
        /// <returns> Returns 1 if any one wins</returns>
        public int CheckIfWon(int[,] a, int val)
        {
            int flag = 0;            
            if (a[0, 0] == val && ((a[0, 1] == val && a[0, 2] == val) || (a[1, 0] == val && a[2, 0] == val)))
            {
                flag = 1;
            }            
            else if (a[1, 1] == val && ((a[0, 0] == val && a[2, 2] == val) || (a[0, 2] == val && a[2, 0] == val)))
            {
                flag = 1;
            }            
            else if (a[1, 0] == val && a[1, 1] == val && a[1, 2] == val)
            {
                flag = 1;
            }            
            else if (a[2, 0] == val && a[2, 1] == val && a[2, 2] == val)
            {
                flag = 1;
            }            
            else if (a[0, 2] == val && a[1, 2] == val && a[2, 2] == val)
            {
                flag = 1;
            }            
            else if (a[0, 1] == val && a[1, 1] == val && a[2, 1] == val)
            {
                flag = 1;
            }

            return flag;
        }

        /// <summary>
        /// Prints the 2 d array of 3*3
        /// </summary>
        /// <param name="array">The array.</param>
        public void PrintGame(int[,] array)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (array[i, j] == 0)
                    {
                        Console.Write("X");
                    }
                    else if (array[i, j] == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// The main game tac toe demo.
        /// </summary>
        public void TicTacToeDemo()
        {
            int[,] array = new int[3, 3];
            int i, j;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i, j] = 2;
                }
            }

            Console.WriteLine("Your positions are marked as X");
            int value, comp, flag = 0;

            for (i = 0; i < 10; i++)
            {
                comp = Utility.RandomIntGenerator(1, 9);
                value = this.ValueAtPosition(array, comp);
                //// If the position is already taken
                while (value == 0 || value == 1)
                {
                    comp = Utility.RandomIntGenerator(1, 9);
                    value = this.ValueAtPosition(array, comp);
                }

                array = this.Enter(array, comp, 1);
                flag = this.CheckIfWon(array, 1);
                if (flag == 1)
                {
                    Console.WriteLine("You losse");
                    this.PrintGame(array);
                    return;
                }

                flag = this.CheckIfEnd(array);
                if (flag == 1)
                {
                    this.PrintGame(array);
                    return;
                }

                this.PrintGame(array);
                Console.WriteLine("Enter the number from 1-9 where you'd like to place the point");
                comp = Utility.IsInteger(Console.ReadLine());
                if (comp == 0)
                {
                    Console.WriteLine("Please enter the value between 0-9");
                } 

                value = this.ValueAtPosition(array, comp);
                while (value == 0 || value == 1)
                {
                    Console.WriteLine("The point is already marked please enter the number");
                    comp = Utility.IsInteger(Console.ReadLine());
                    value = this.ValueAtPosition(array, comp);
                }

                array = this.Enter(array, comp, 0);
                flag = this.CheckIfWon(array, 0);
                if (flag == 1)
                {
                    Console.WriteLine("You Win");
                    this.PrintGame(array);
                    return;
                }

                flag = this.CheckIfEnd(array);
                if (flag == 1)
                {
                    this.PrintGame(array);
                    return;
                }
            }
        }
    }
}
