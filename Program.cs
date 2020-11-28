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
        const int IS_FULL_TIME = 1;
        const int ISS_PART_TIME = 2;
        const int EMPLOYEE_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS_PERMONTH = 20;
        const int MAX_WORKING_HOURS = 100;
        public static void calculateEmpWage()
        { 
        int empHrs;
        int totalWAage = 0;
        int totalEmpHours = 0;
        int workingDays = 0;
        Random rand = new Random();
        while(totalEmpHours<MAX_WORKING_HOURS && workingDays<=NUM_OF_WORKING_DAYS_PERMONTH )
        {
            if (totalEmpHours == 96)
            {
               empHrs = 4;
            }

        int empcheck = rand.Next(0, 3);
        switch (empcheck)
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
            totalEmpHours = totalEmpHours + empHrs;
            Console.WriteLine(totalEmpHours);
            Console.WriteLine(workingDays);
            workingDays++;
       }
       totalWAage = totalEmpHours * EMPLOYEE_RATE_PER_HOUR;
       Console.WriteLine("The total wage of worker per month is {0}", totalWAage);
        }


        static void Main(string[] args)
        {
            calculateEmpWage();
        }
    }
}
