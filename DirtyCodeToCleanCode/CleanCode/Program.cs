
using CleanCode.Application;
using CleanCode.Models;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSheetEntries = loadEntriesFromUser();
            var companies = new CompanyService().GetCompanies();
            var billManager = new BillManager();
            var emailService = new EMailService(billManager);

            emailService.SimulateEmail(companies, timeSheetEntries);
            double totalHoursInAWeek = timeSheetEntries.Sum(time => time.HoursWorked);

            var extra = billManager.GetExtraPayment(totalHoursInAWeek, maxWeeklyWorkingHour: 40, normalPrice: 10, extraPrice: 15);
            Console.WriteLine("You will get paid $" + extra + " for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static List<TimeSheetEntry> loadEntriesFromUser()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();

            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string jobDescription = Console.ReadLine();
                double totalHoursForJob = getHoursInfoFromUser();
                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = totalHoursForJob,
                    WorkDone = jobDescription
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() == UserAnswer.YES);


            return timeSheetEntries; ;
        }

        private static double getHoursInfoFromUser()
        {
            double totalHoursForJob = 0.0;
            string rawTimeWorked = string.Empty;
            var isDouble = true;
            do
            {
                string message = isDouble ? string.Empty : "Please give a valid number! ";
                Console.Write($"{message}How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
                isDouble = double.TryParse(rawTimeWorked, out totalHoursForJob);
            } while (!isDouble);

            return totalHoursForJob;

        }


       

       

       
    }
}
