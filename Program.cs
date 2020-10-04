using System;

namespace UC2
{
    class Program
    {

        static void Main(string[] args)
        {
            //constant
            int Wage_per_hour = 20;
            int present = 1;
            //variable
            Random random = new Random();
            int empWage = 0;
            int empHour = 0;
            //Computation
            int isPresent = random.Next(0, 2);
            if (isPresent == present)
                empHour = 8;
            else
                empHour = 0;
            empWage = empHour * Wage_per_hour;
            Console.WriteLine("EmpWage " + empWage);

        }
    }
}