// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeWage.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace DailyWageProblem
{
    // employee check program
    //UC1
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            Random rand = new Random();
            int empcheck = rand.Next(0, 2);
            if (empcheck == 1)
            {
                Console.WriteLine("employee is present!");
            }
            else
            {
                Console.WriteLine("employee is absent!");
            } 
        }
    }
}
