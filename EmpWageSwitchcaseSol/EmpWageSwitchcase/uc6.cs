using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageSwitchcase
{
    internal class Empwageformonth
    {
        static void totalwage(string[] args)
        {
            //constant
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int NO_OF_WORKING_DAYS = 20;
            const int MAX_HRS_IN_A_MONTH = 100;
            //variables
            int empHrs = 0;
            int Totalworkingdays = 0;
            int totalEmphrs = 0;
            while(empHrs <= MAX_HRS_IN_A_MONTH && Totalworkingdays < NO_OF_WORKING_DAYS)
            {
                Totalworkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
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
                
                totalEmphrs += empHrs;
                Console.Write("days:" + Totalworkingdays +"employee hours" +empHrs);
            }
            int Totalempwage = totalEmphrs * WAGE_PER_HOUR;
            Console.Write("Total employee wage is" + Totalempwage);

        }
    }
}
