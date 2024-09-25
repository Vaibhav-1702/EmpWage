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
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOURS = 8;

        static void Main(string[] args)
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);

            if (attendance == IS_PRESENT)
            {
                int dailyWage = WAGE_PER_HOUR * FULL_DAY_HOURS;
                Console.WriteLine("Employee is Present, Daily Wage is: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent, Daily Wage is: 0");
            }
        }
    }
}


