using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class UserName
    {
        public void UserInput()
        {
            //name stores the username entered 
            string name;
            Console.WriteLine("Enter your username");
            name = Utility.IsString(Console.ReadLine());
            //Calls a static method to check if it is a string
            string Template = "Hello <<UserName>>, How are you?";
            //Replacing the username by the one which is entered by the customer
            Template = Template.Replace("<<UserName>>", name);
            Console.WriteLine(Template);
        }
    }
}
