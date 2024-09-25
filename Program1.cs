using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage1
{
    class Program
    {
        public const int IS_PRESENT = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOURS = 8;
        public const int PART_TIME_HOURS = 4;
        public const int WORKING_DAYS_PER_MONTH = 20;

        static void Main(string[] args)
        {
            int totalWage = 0;
            Random random = new Random();

            for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)
            {
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

                int dailyWage = WAGE_PER_HOUR * hoursWorked;
                totalWage += dailyWage;
            }

            Console.WriteLine("Total Wage for the Month: " + totalWage);
        }
    }
}


