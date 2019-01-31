// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserName.cs" company="Bridgelabz">
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
    /// user name takes the string as input and prints the result
    /// </summary>
    public class UserName
    {
        /// <summary>
        /// Users the input.
        /// </summary>
        public void UserInput()
        {
            try
            {
                //// name stores the username entered 
                string name;
                Console.WriteLine("Enter your username");
                name = Utility.IsString(Console.ReadLine());
                //// Calls a static method to check if it is a string
                string template = "Hello <<UserName>>, How are you?";
                //// Replacing the username by the one which is entered by the customer
                template = template.Replace("<<UserName>>", name);
                Console.WriteLine(template);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
