using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice2_Prat2_Inhertance_Polymophism
{
    class Employee
    {
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string Jobs { get; set; }
        public int Salary { get; set; }

        public Employee(string companyName, string companyEmail, string jobs, int salary)
        {
            CompanyName = companyName;
            CompanyEmail = companyEmail;
            Jobs = jobs;
            Salary = salary;
        }

        public Employee()
        {
        }
    }
}
