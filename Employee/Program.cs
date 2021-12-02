using System;
class program
{ 
        public const int IS_PART_TIME = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
    static void Main(string[] args)
    {
        int empHrs = 0, empWage = 0, totalEmpwage = 0;
        for (int day = 0; day < Num_Of_Working_Days; day++)
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case Is_Full_Time:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            int v = empHrs * Emp_Rate_Per_Hour;
            empWage = v;
            totalEmpwage += empWage;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        Console.WriteLine("Total Emp Wage : " + totalEmpwage);
    }
}
