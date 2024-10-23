using EmployeeInterface;

namespace Employee_Application
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void computeSalaryBtn_Click(object sender, EventArgs e)
        {
            string firstNameStr = firstNameTxtBx.Text;
            string lastNameStr = lastNameTxtBx.Text;
            string departmentStr = departmentTxtBx.Text;
            string jobTitleeStr = jobTitleTxtBx.Text;
            double ratePerHrStr = Convert.ToDouble(rateTxtBx.Text);
            int totalHrsStr = Convert.ToInt32(totalHrsTxtBx.Text);

            EmployeeNamespace.PartTimeEmployee partTimeEmployee = new EmployeeNamespace.PartTimeEmployee(firstNameStr, lastNameStr, departmentStr, jobTitleeStr);

            firstNameTxt.Text = partTimeEmployee.FirstName;
            lastNameTxt.Text = partTimeEmployee.LastName;
            partTimeEmployee.computeSalary(totalHrsStr, ratePerHrStr);
        
            basicSalaryTxt.Text = partTimeEmployee.getSalary().ToString();


        }
    }
}

