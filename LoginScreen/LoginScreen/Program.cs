﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            // login screen that accepts login name and password. 
            // Allow the user a maximum of 3 chances only. 
            // In case the user is unsuccessful in logging in after three attempts
            // exit the application.
            Console.Write("Enter login: ");
            string LogIn = Console.ReadLine();
            string riteLogin = "admin";



            if (LogIn == riteLogin)
            {
                Console.Write("Enter password: ");
                string passWord = Console.ReadLine();
                string ritePassword = "password";
                if (passWord == ritePassword)
                {
                    Console.WriteLine(" Welcome to Program");
                }
                else Console.WriteLine("Please try again later. ");

            }
            else Console.WriteLine("Please try again later. ");
            Console.ReadKey();

           

           

            Console.ReadKey();


        }
    }
}
