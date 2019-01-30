// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
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
    /// Plays the gambler game
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Method to play the gambler game.
        /// </summary>
        public void GamblerGame()
        {
            int stake, goal, games, count = 0, wins = 0, perwins;
            Random rand = new Random();
            Console.WriteLine("Enter the value of stake number of games played");
            try
            {
                stake = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please try entering value again again");
                stake = Utility.IsInteger(Console.ReadLine());
            }

            Console.WriteLine("Enter the goal");
            try
            {
                goal = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please try entering value again again");
                goal = Utility.IsInteger(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of games played");
            try
            {
                games = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please try entering value again again");
                games = Utility.IsInteger(Console.ReadLine());
            }
            ////It tries untill the stake is 0 or the goal is reached
            while (stake != 0 && stake < goal && count < games)
            {
                if (rand.NextDouble() > 0.5)
                {
                    stake++;
                    wins++;
                }
                else
                {
                    stake--;
                }

                count++;
            }

            perwins = wins * 100 / count;
            Console.WriteLine("Wins : {0} , percent of Wins: {1} and percent of loss is {2} ", wins, perwins, 100 - perwins);
        }
    }
}
