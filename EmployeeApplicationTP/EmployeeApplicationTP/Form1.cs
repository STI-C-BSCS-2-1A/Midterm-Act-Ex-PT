namespace EmployeeApplicationTP
{
    public partial class frmComputerSalary : Form
    {
        public frmComputerSalary()
        {
            InitializeComponent();
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
           
            EmployeeNamespace.PartTimeEmployee employee = new EmployeeNamespace.PartTimeEmployee
            (
            FNametxt.Text,
            LNametxt.Text,
            Departmenttxt.Text,
            JobTitletxt.Text
            );

            
            int hoursWorked = Convert.ToInt32(TotalHourstxt.Text);
            double ratePerHour = Convert.ToDouble(Ratetxt.Text);

          
            employee.ComputeSalary(hoursWorked, ratePerHour);

           
            Salarylbl.Text = "Basic Salary: " + employee.BasicSalary.ToString("C2");

          
            FNamelbl.Text = "First Name: " + employee.FirstName;
            LNamelbl.Text = "Last Name: " + employee.LastName;
        }

    }

}

namespace EmployeeNamespace
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; }

        void ComputeSalary(int hoursWorked, double ratePerHour);
    }

    public class PartTimeEmployee : IEmployee
    {
       
        private string firstName;
        private string lastName;
        private string Department;
        private string jobTitle;
        private double basicSalary;

        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            firstName = FName;
            lastName = LName;
            Department = dept;
            jobTitle = job;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string department
        {
            get { return Department; }
            set { Department = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public double BasicSalary
        {
            get { return basicSalary; }
        }

       
        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            basicSalary = hoursWorked * ratePerHour;
        }
    }
}
