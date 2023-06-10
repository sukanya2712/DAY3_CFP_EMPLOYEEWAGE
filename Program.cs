namespace Employeewage
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            
            int empHrs;
            int empWage;
            Random random = new Random();
            int empCheck = random.Next(0,3);
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
            Console.WriteLine($"Wage of the employee is :- {empWage}");
        }
    }
}