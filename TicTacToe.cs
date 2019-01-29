using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TicTacToe
    {
        int valueAtPosition(int[,] array, int index)
        {
            int j, i = 0, num = 0;

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    num++;
                    if (num == index)
                    {
                        return array[i,j];
                    }
                }
            }
            return 1;
        }
        int[,] enter(int[,] array, int index, int number)
        {
            int i = 0, j=0 , num=0;

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    num++;
                    if (num == index)
                    {
                        array[i,j]=number;
                    }
                }
            }
            return array;
        }
        int checkIfEnd(int[,] a)
        {
            int i, j, flag = 1;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (a[i,j] == 0 || a[i,j] == 1) continue;
                    else flag = 0;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("game over");
                return flag;
            }
            return flag;
        }
        int checkIfWon(int[,] a, int val)
        {
            int flag = 0;
            //top and left line
            if (a[0,0] == val && ((a[0,1] == val && a[0,2] == val) || (a[1,0] == val && a[2,0] == val))) flag = 1;
            //daigonals
            else if (a[1,1] == val && ((a[0,0] == val && a[2,2] == val) || (a[0,2] == val && a[2,0] == val))) flag = 1;
            //middle horizontal
            else if (a[1,0] == val && a[1,1] == val && a[1,2] == val) flag = 1;
            //bottom line
            else if (a[2,0] == val && a[2,1] == val && a[2,2] == val) flag = 1;
            //Third vertical line
            else if (a[0,2] == val && a[1,2] == val && a[2,2] == val) flag = 1;
            //middle vertical line
            else if (a[0,1] == val && a[1,1] == val && a[2,1] == val) flag = 1;

            return flag;
        }
        void printGame(int[,] array)
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    if (array[i,j] == 0) Console.Write("X");
				else if (array[i,j] == 1) Console.Write("O");
                    else Console.Write("-");
                }
                Console.WriteLine();
            }
        }
        public void TicTacToeDemo()
        {
            int[,] array = new int[3,3];
            int i, j;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i,j] = 2;
                }
            }

            Console.WriteLine("Your positions are marked as X");
            int value, comp, flag = 0;

            for (i = 0; i < 10; i++)
            {

                comp = Utility.RandomIntGenerator(1,9);
                value = valueAtPosition(array, comp);

                while (value == 0 || value == 1)
                {
                    comp = Utility.RandomIntGenerator(1, 9);
                    value = valueAtPosition(array, comp);
                }

                array = enter(array, comp, 1);
                flag = checkIfWon(array, 1);
                if (flag == 1)
                {
                    Console.WriteLine("You losse");
                    printGame(array);
                    return;
                }
                flag = checkIfEnd(array);
                if (flag == 1)
                {
                    printGame(array);
                    return;
                }
                printGame(array);
                Console.WriteLine("Enter the number from 1-9 where you'd like to place the point");
              
                comp = Convert.ToInt32(Console.ReadLine());
                value = valueAtPosition(array, comp);
                while (value == 0 || value == 1)
                {
                    Console.WriteLine("The point is already marked please enter the number");
                    comp = comp = Convert.ToInt32(Console.ReadLine());
                    value = valueAtPosition(array, comp);
                }
                array = enter(array, comp, 0);
                flag = checkIfWon(array, 0);
                if (flag == 1)
                {
                    Console.WriteLine("You Win");
                    printGame(array);
                    return;
                }
                flag = checkIfEnd(array);
                if (flag == 1)
                {
                    printGame(array);
                    return;
                }
            }

        }
    }
}
