using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplicationTP
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void bt_computeSalary_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather input data from the form
                string firstName = tb_firstName.Text;
                string lastName = tb_lastName.Text;
                string department = tb_department.Text;
                string jobTitle = tb_jobTitle.Text;
                double ratePerHour = double.Parse(tb_rate.Text);
                double hoursWorked = double.Parse(tb_totalhour.Text);

                // Create a new PartTimeEmployee object
                PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle, ratePerHour, hoursWorked);

                // Compute the salary
                double salary = employee.ComputeSalary();

                // Display the employee information and salary
                lb_firstName.Text = $"First Name: {employee.FirstName}";
                lb_lastName.Text = $"Last Name: {employee.LastName}";
                lb_basicSalary.Text =$"Basic Salary: { salary}";  // Format as currency
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
