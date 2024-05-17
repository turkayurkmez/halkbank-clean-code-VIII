using CleanCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class EMailService
    {

        private readonly BillManager billManager;

        public EMailService(BillManager billManager)
        {
            this.billManager = billManager;
        }

        public void SimulateEmail(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
        {

            foreach (var company in companies)
            {

                var billForCompany = billManager.GetTotalBillForCompany(timeSheetEntries, company);
                Console.WriteLine($"Simulating Sending email to {company.Name}");
                Console.WriteLine("Your bill is $" + billForCompany + " for the hours worked.");
            }
        }
    }
}
