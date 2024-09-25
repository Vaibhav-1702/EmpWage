using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage1
{
    class EmployeeWageCalculator
    {
        public const int IS_PRESENT = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOURS = 8;
        public const int PART_TIME_HOURS = 4;
        public const int WORKING_DAYS_LIMIT = 20;
        public const int WORKING_HOURS_LIMIT = 100;

        public int CalculateEmployeeWage()
        {
            int totalWage = 0;
            int totalHoursWorked = 0;
            int totalWorkingDays = 0;
            Random random = new Random();

            while (totalWorkingDays < WORKING_DAYS_LIMIT && totalHoursWorked < WORKING_HOURS_LIMIT)
            {
                totalWorkingDays++;
                int attendance = random.Next(0, 3);
                int hoursWorked = 0;

                switch (attendance)
                {
                    case IS_PRESENT:
                        hoursWorked = FULL_DAY_HOURS;
                        break;
                    case IS_PART_TIME:
                        hoursWorked = PART_TIME_HOURS;
                        break;
                    default:
                        hoursWorked = 0;
                        break;
                }

                totalHoursWorked += hoursWorked;
                int dailyWage = WAGE_PER_HOUR * hoursWorked;
                totalWage += dailyWage;
            }

            return totalWage;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWageCalculator employeeWageCalculator = new EmployeeWageCalculator();
            int totalWage = employeeWageCalculator.CalculateEmployeeWage();
            Console.WriteLine("Total Wage for the Month: " + totalWage);
        }
    }
}


