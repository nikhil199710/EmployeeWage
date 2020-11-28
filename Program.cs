// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeWage.cs" company="Bridgelabz">
//   Copyright © 2018 Company// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace DailyWageProblem
{
    class Program
    {
        
        //UC2
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            int EMPLOYEE_RATE_PER_HOUR = 20;
            int empHrs;
            int totalWAage;
            Random rand = new Random();
            int empcheck = rand.Next(0, 2);
            if (empcheck == 1)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            totalWAage = empHrs * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("The total wage of worker per day is {0}",totalWAage);
        }
    }
}
