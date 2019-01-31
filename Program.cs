// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// The entry point to the project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                string[] programs =
                {
                "Username", "Head&Tails", "LeapYear", "TableforPowerof2 COMMAND LINE ARGUMENTS NEEDED",
                "HarmonicNumber", "PrimeFactors", "Gambler", "CouponNumber", "2dArray",
                "Sumof3toZero", "Distance", "Permutations", "StopWatch", "TicTacToe", "Quadratic",
                "WindChill COMMAND LINE ARGUMENTS NEEDED"
            };
                int i, number;
                for (i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine("Enter {0} for {1}", i + 1, programs[i]);
                }

                int flag = 1;
                do
                {
                    for (i = 0; i < programs.Length; i++)
                    {
                        Console.WriteLine("Enter {0} for {1}", i + 1, programs[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                    try
                    {
                        number = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please try entering value again again");
                        number = Utility.IsInteger(Console.ReadLine());
                    }

                    Console.WriteLine("num : {0}", number);
                    switch (number)
                    {
                        case 0:
                            return;
                        case 1:
                            UserName f = new UserName();
                            f.UserInput();
                            break;
                        case 2:
                            FlipCoin c = new FlipCoin();
                            c.Toss();
                            break;
                        case 3:
                            LeapYear ly = new LeapYear();
                            ly.Leap();
                            break;
                        case 4:
                            PowerOfTwo p = new PowerOfTwo();
                            p.PowerTwo(Convert.ToInt32(args[0]));
                            break;
                        case 5:
                            Harmonic h = new Harmonic();
                            h.NHarmonic();
                            break;
                        case 6:
                            PrimeFactors fa = new PrimeFactors();
                            fa.PrimeFactorsfor();
                            break;
                        case 7:
                            Gambler g = new Gambler();
                            g.GamblerGame();
                            break;
                        case 8:
                            Coupon co = new Coupon();
                            co.CouponGame();
                            break;
                        case 9:
                            ArrayTwoDim atd = new ArrayTwoDim();
                            atd.Array2D();
                            break;
                        case 10:
                            ZeroTriplets zt = new ZeroTriplets();
                            zt.Triplets();
                            break;
                        case 11:
                            Distance di = new Distance();
                            di.SqrtDistance();
                            break;
                        case 12:
                            Permutations pe = new Permutations();
                            pe.StringPermutations();
                            break;
                        case 13:
                            StopWatch sw = new StopWatch();
                            sw.StopWatchDemo();
                            break;
                        case 14:
                            TicTacToe tt = new TicTacToe();
                            tt.TicTacToeDemo();
                            break;
                        case 15:
                            Quadratic q = new Quadratic();
                            q.QuadraticDemo();
                            break;
                        case 16:
                            WindChill wc = new WindChill();
                            wc.WindChillDemo(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
                            break;
                        default:
                            Console.WriteLine("Not yet created");
                            flag = 0;
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                while (flag == 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }    
    }
}
