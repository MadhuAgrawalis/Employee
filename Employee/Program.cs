using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                int Fulltime = 1;
                int Per_hr_rate = 20;
                int emp_hr = 0;
                int emp_wage = 0;
                Random random_num = new Random();
                int checkemp = random_num.Next(0, 2);
                if (checkemp == Fulltime)
                {
                    emp_hr = 8;
                }
                else
                {
                    emp_hr = 0;
                }
                emp_wage = emp_hr * Per_hr_rate;
                Console.WriteLine("Employee Wage:-" + emp_wage);


            
        }





    }
    
}
