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

        static void Main(string[] args)
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);

            if (attendance == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}


