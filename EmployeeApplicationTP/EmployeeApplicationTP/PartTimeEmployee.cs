using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double RatePerHour { get; set; }
        public double HoursWorked { get; set; }

        // Constructor
        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle, double ratePerHour, double hoursWorked)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            JobTitle = jobTitle;
            RatePerHour = ratePerHour;
            HoursWorked = hoursWorked;
        }

        // Method to compute the salary
        public double ComputeSalary()
        {
            return RatePerHour * HoursWorked;
        }
    }
}