using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                int Fulltime = 1;
                Random random_num = new Random();
                int checkemp = random_num.Next(0, 2);
                if (checkemp == Fulltime)
                {
                    Console.WriteLine("Employee Is Present");
                }
                else
                {
                    Console.Write("Employee is Absent");
                }


            
        }
    }
}
