namespace Employeewage
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
            
            int empHrs=0;
            int empWage=0;
            int totalEmpWage = 0;
            for(int day=0;day< NUM_OF_WORKING_DAYS; day++)
            {
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
                empWage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empWage;
                Console.WriteLine($"Wage of the employee is :- {empWage}");
            }
            Console.WriteLine("Total empWage :" + totalEmpWage);
        }
    }
}