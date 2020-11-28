// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeWage.cs" company="Bridgelabz">
//   Copyright © 2018 Company// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Threading;

namespace EmpWage

{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        private LinkedList<int> compDailyEmpWageList;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
            this.compDailyEmpWageList = new LinkedList<int>();

        }
      
        public void setDailyEmpWage(LinkedList<int> compDailyEmpWageList)
        {
            this.compDailyEmpWageList = compDailyEmpWageList;
            int totalEmpWage = 0;
            foreach (int a in this.compDailyEmpWageList)
            {
                totalEmpWage += a;
            }
            totalEmpWage = totalEmpWage * empRatePerHour;
            this.totalEmpWage = totalEmpWage;

        }

        public string toString()
        {
            return "Total Emp Wage for the company : " + this.company + " is " + this.totalEmpWage;
        }

    }

    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private LinkedList<CompanyEmpWage> compEmpWageList;
        
        public EmpWageBuilderArray()
        {
            this.compEmpWageList = new LinkedList<CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.compEmpWageList.AddLast(companyEmpWage);


        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.compEmpWageList)
            {
                //companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                companyEmpWage.setDailyEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());


            }

        }

        private LinkedList<int> computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int dailyWage;
            LinkedList<int> returnDailyWageList = new LinkedList<int>();
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numofWorkingDays)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                dailyWage = empHrs * companyEmpWage.empRatePerHour;
                //compDailyEmpWageList.AddLast(dailyWage);
                returnDailyWageList.AddLast(dailyWage);
                totalEmpHrs += empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hrs " + empHrs + " dailywage: " + dailyWage);


            }

            //return totalEmpHrs * companyEmpWage.empRatePerHour;
            return returnDailyWageList;


        }
    } 
    
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMART", 10, 20, 90);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}
