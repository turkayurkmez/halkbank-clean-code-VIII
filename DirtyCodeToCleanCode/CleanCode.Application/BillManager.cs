using CleanCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class BillManager
    {
        public double GetTotalBillForCompany(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            var totalHoursInAWeek = timeSheetEntries
                                    .Where(entry => entry.WorkDone.ToLower().Contains(company.Name.ToLower()))
                                    .Sum(entry => entry.HoursWorked);

            return totalHoursInAWeek * company.HourlyPrice;
        }

        public double GetExtraPayment(double totalHoursInAWeek, double maxWeeklyWorkingHour, double normalPrice, double extraPrice)
        {

            double extraPayment = 0;
            if (totalHoursInAWeek > maxWeeklyWorkingHour)
            {
                var moreThanNormal = (totalHoursInAWeek - maxWeeklyWorkingHour) * extraPrice;
                var normal = maxWeeklyWorkingHour * normalPrice;
                extraPayment = moreThanNormal + normal;
            }
            else
            {
                extraPayment = totalHoursInAWeek * normalPrice;
            }

            return extraPayment;

        }
    }
}
