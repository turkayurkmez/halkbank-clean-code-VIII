using CleanCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Application
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                new Company{ Name="ABC", HourlyPrice=125},
                new Company{ Name="Acme", HourlyPrice=150},
            };
        }
    }
}
