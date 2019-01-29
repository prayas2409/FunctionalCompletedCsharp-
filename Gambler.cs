using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Gambler
    {
        public void GamblerGame()
        {
            int stake, goal, games, count=0 , wins=0, perwins;
            Random rand = new Random();
            Console.WriteLine("Enter the value of stake number of games played");
            stake = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the goal");
            goal= Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the number of games played");
            games = Utility.IsInteger(Console.ReadLine());
            while(stake!=0 && stake < goal && count<games)
            {
                if (rand.NextDouble() > 0.5)
                {
                    stake++;
                    wins++;
                }
                else stake--;
                count++;
            }
            perwins = wins * 100 / count;
            Console.WriteLine("Wins : {0} , percent of Wins: {1} and percent of loss is {2} ",wins ,perwins, 100- perwins);
        } 
    }
}
