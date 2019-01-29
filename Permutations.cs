using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Permutations
    {
        public void StringPermutations()
        {
            String var;
            int i;
            Console.WriteLine("Enter the string to find the permutations");
            var = Utility.IsString(Console.ReadLine());
            for (i = 0; i < var.Length; i++)
            {
                Console.WriteLine("For {0} ",var[i]);
                permute(var[i].ToString(), var.Remove(i, 1),0);
                Console.WriteLine();
            }
        }
        public void permute(String upto, String remaining,int num)
        {
            num++;
            if (remaining.Length == 0)
            {
                Console.Write("{0} ",upto);
            }
            else
            {
                int i = 0;
                String temp1 = upto, temp2 = remaining;
                while (i<remaining.Length)
                {
                    upto = upto + remaining[i];
                    remaining = remaining.Remove(i, 1);
                    permute(upto, remaining, num);
                    upto = temp1;
                    remaining = temp2;
                    i++;
                }
            }
        }
    }
}
