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

        static void Main(string[] args)
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);

            int hoursWorked = 0;
            switch (attendance)
            {
                case IS_PRESENT:
                    hoursWorked = FULL_DAY_HOURS;
                    Console.WriteLine("Employee is Present for Full Time");
                    break;
                case IS_PART_TIME:
                    hoursWorked = PART_TIME_HOURS;
                    Console.WriteLine("Employee is Present for Part Time");
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }

            int dailyWage = WAGE_PER_HOUR * hoursWorked;
            Console.WriteLine("Daily Wage is: " + dailyWage);
        }
    }
}


