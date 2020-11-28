
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeWage.cs" company="Bridgelabz">
//   Copyright © 2018 Company// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Security.Cryptography.X509Certificates;

namespace DailyWageProblem
{
    class EmployeeWageComputation
    {
        const int IS_FULL_TIME = 1;
        const int ISS_PART_TIME = 2;
        private string companyName;
        private int maxWorkingHours;
        private int maxNumOfWorkingDays;
        private int ratePerHour;
        private int totalWage = 0;

        public EmployeeWageComputation(string companyName, int maxWorkingHours, int maxNumOfWorkingDays, int ratePerHour)
        {
            this.companyName = companyName;
            this.maxWorkingHours = maxWorkingHours;
            this.maxNumOfWorkingDays = maxNumOfWorkingDays;
            this.ratePerHour = ratePerHour;

        }

        public void calculateEmpWage()
        {
            int empHrs;

            int totalEmpHours = 0;
            int workingDays = 0;
            Random rand = new Random();
            while (totalEmpHours < maxWorkingHours && workingDays < maxNumOfWorkingDays)

            {

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
                Console.WriteLine("the total working days is " + workingDays + "and working hours is " + totalEmpHours);

                workingDays++;
            }

            totalWage = totalEmpHours * ratePerHour;
            Console.WriteLine("The total wage of worker for" + companyName + "is:" + totalWage);


        }
         public string information()
        {
            return "Total wage for" + this.companyName + "is:" + this.totalWage;
        }
    }

        class Program
        {


            static void Main(string[] args)
            {
                EmployeeWageComputation TATA = new EmployeeWageComputation("Dmart", 60, 50, 20);
                EmployeeWageComputation Amazon = new EmployeeWageComputation("Reliance", 40, 70, 50);
                Dmart.calculateEmpWage();
                Reliance.calculateEmpWage();
                Console.WriteLine(Dmart.information());
                Console.WriteLine(Reliance.information());
            }
        }
}
