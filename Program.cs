namespace Employeewage
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int computeEmpWage(string company,int empRatePerHour,int numofWorkingDays,int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                totalEmpHrs += empHrs;
                Console.WriteLine("DAY:" + totalWorkingDays + " EMPHOURS:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("company name :" + company + "   Total empWage :" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("RELIANCE",20,2,10);
            computeEmpWage("TATA", 10, 4, 20);
            
        }
    }
}