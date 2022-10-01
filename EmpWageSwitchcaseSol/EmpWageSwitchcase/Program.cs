using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace EmpWage;
class EmpWage
{
    static void Main(string[] args)
    {
        //constant
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int WAGE_PER_HOUR = 20;
        const int NO_OF_WORKING_DAYS = 20;
        //variables
        int empHrs=0;
        int empWage=0;
        int totalEmpwage = 0;
        for (int day = 0; day < NO_OF_WORKING_DAYS; day++)
        {
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
            empWage = empHrs * WAGE_PER_HOUR;
            totalEmpwage += empWage;
            Console.Write("employe wage:" + empWage);
        }
        Console.Write("Total employee wage is" + totalEmpwage);

    }
}