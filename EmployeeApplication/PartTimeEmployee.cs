using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle, decimal hourlyRate, int hoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public decimal ComputeSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}