using System;

namespace DailyWageProblem
{
    class Program
    {
        const int IS_FULL_TIME = 1;
        const int ISS_PART_TIME = 2;
        
      
        public static void calculateEmpWage(string companyName,int maxWorkingHours,int maxNumOfWorkingDays,int ratePerHour)
        { 
         int empHrs;
         int totalWAage = 0;
         int totalEmpHours = 0;
         int workingDays = 0;
         Random rand = new Random();
         while(totalEmpHours < maxWorkingHours && workingDays< maxNumOfWorkingDays )
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
           Console.WriteLine(totalEmpHours);
           Console.WriteLine(workingDays);
           workingDays++;
            }
         totalWAage = totalEmpHours * ratePerHour;
         Console.WriteLine("The total wage of worker per month is {0}", totalWAage);
        }


        static void Main(string[] args)
        {
            calculateEmpWage("Dmart",50,25,15);
            calculateEmpWage("Reliance", 60, 52, 54);
        }
    }
}
