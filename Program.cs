namespace Employeewage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs;
            int empWage;
            Random random = new Random();
            int empCheck = random.Next(0,3);
            if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 4;
            }
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is not present");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine($"Wage of the employee is :- {empWage}");
        }
    }
}