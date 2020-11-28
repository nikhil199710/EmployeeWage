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
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int ISS_PART_TIME = 2;
            int EMPLOYEE_RATE_PER_HOUR = 20;
            int empHrs;
            int totalWAage;
            Random rand = new Random();
            int empcheck = rand.Next(0, 3);
            switch(empcheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case ISS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalWAage = empHrs * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("The total wage of worker per day is {0}", totalWAage);

        }
    }
}
