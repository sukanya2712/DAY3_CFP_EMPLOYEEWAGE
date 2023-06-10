namespace Employeewage
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        static void Main(string[] args)
        {
            
            int empHrs=0;
            int totalWorkingDays=0;
            int totalEmpHrs = 0;

            while(totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingDays< NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is present");
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is present");
                        empHrs = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is not present");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("DAY:"+totalWorkingDays+" EMPHOURS:"+ empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total empWage :" + totalEmpWage);
        }
    }
}