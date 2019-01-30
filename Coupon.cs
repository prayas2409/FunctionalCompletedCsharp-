﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon.cs" company="Bridgelabz">
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
    /// class executes the program for Coupon
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Plays the coupon game
        /// </summary>
        public void CouponGame()
        {
            //// numcoupon stores range of coupon, rand stores random generator
            //// counter counts till the number of coupons are traversed
            //// count counts all the number of coupons are generated by random
            //// rcoupon number of times we're generating random number
            int numcoupon, rand, counter = 0, count = 0, rcoupon = 0;
            Console.WriteLine("Enter the range of coupons");
            try
            {   //// trying to get integer input
                numcoupon = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please try again");
                numcoupon = Utility.IsInteger(Console.ReadLine());
            }
            //// coupons store all the coupons in given range
            int[] coupons = new int[numcoupon];
            //// couponcounter stores if the number was generated previosuly
            int[] couponscounter = new int[numcoupon];
            //// initializing counting array and th ecoupon array
            for (counter = 0; counter < numcoupon; counter++)
            {
                coupons[counter] = counter + 1;
                couponscounter[counter] = 0;
            }
            //// trying to generate new tokens
            while (count < numcoupon)
            {
                count = 0;
                rcoupon++;
                rand = Utility.RandomIntGenerator(1, numcoupon + 1);
                Console.WriteLine("random {0} ", rand);
                
                Console.WriteLine();
                if (count >= numcoupon)
                {
                    break;
                }
                else
                {
                    //// checking if the number is new
                    for (counter = 0; counter < numcoupon; counter++)
                    {
                        if (coupons[counter] == rand && couponscounter[counter] == 0)
                        {
                            couponscounter[counter] = 1;
                            break;
                        }
                    }
                }
                //checking if all the elements are generated
                for (counter = 0; counter < numcoupon; counter++)
                {
                    if (couponscounter[counter] == 1)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Total random numbers needed: {0} ", rcoupon);
        }
    }
}
