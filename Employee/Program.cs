using System;
class program
{ 
        public const int IS_PART_TIME = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hrs_in_Month = 10;
    static void Main(string[] args)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= Max_Hrs_in_Month && totalWorkingDays < Num_Of_Working_Days)
        {
            totalWorkingDays++;           
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

            
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
        }
        int totalEmpwage = totalEmpHrs * Emp_Rate_Per_Hour;
        Console.WriteLine("Total Emp Wage : " + totalEmpwage);
    }
}
