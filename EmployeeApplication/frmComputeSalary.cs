using EmployeeInterface;
using System.Windows.Forms;

namespace EmployeeNamespace
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();

            departmentList.Items.Add("-Select Department-");
            departmentList.Items.Add("Executive Management");
            departmentList.Items.Add("Product Development/Management");
            departmentList.Items.Add("Engineering");
            departmentList.Items.Add("Research and Development (R&D)");
            departmentList.Items.Add("Information Technology (IT)");
            departmentList.Items.Add("Data Science and Analytics");
            departmentList.Items.Add("User Experience (UX) and User Inteface (UI)");
            departmentList.Items.Add("Sales and Business Development");
            departmentList.Items.Add("Marketing");
            departmentList.Items.Add("Customer Support");
            departmentList.Items.Add("Cybersecurity");
            departmentList.Items.Add("Legal Compliance");
            departmentList.Items.Add("Human Resources (HR)");
            departmentList.Items.Add("Technical Writing");
            departmentList.Items.Add("Operations");
            departmentList.Items.Add("Cloud Services/Infrastructure");
            departmentList.Items.Add("Corporate Social Responsibility (CSR)");
            departmentList.Items.Add("Event Management");
            departmentList.Items.Add("Training and Development");
            departmentList.Items.Add("Technical Support");

            departmentList.SelectedIndexChanged += DepartmentList_SelectedIndexChanged;
        }

        private void DepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            jobTitleList.Items.Clear();

            if (departmentList.SelectedItem != null)
            {
                string selectedDepartment = departmentList.SelectedItem.ToString();

                switch (selectedDepartment)
                {
                    case "-Select Department-":
                        jobTitleList.Items.Add("-Select Job Title-");
                        break;
                    case "Executive Management":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Chief Executive Officer");
                        jobTitleList.Items.Add("Chief Operating Officer");
                        jobTitleList.Items.Add("Chief Technology Officer");
                        jobTitleList.Items.Add("Chief Financial Officer");
                        jobTitleList.Items.Add("Chief Marketing Officer");
                        jobTitleList.Items.Add("Chief Information Officer");
                        jobTitleList.Items.Add("Chief Product Officer");
                        jobTitleList.Items.Add("Chief Strategy Officer");
                        break;
                    case "Product Development/Management":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Product Manager");
                        jobTitleList.Items.Add("Associate Product Manager");
                        jobTitleList.Items.Add("Senior Product Manager");
                        jobTitleList.Items.Add("Product Owner");
                        jobTitleList.Items.Add("Product Designer");
                        jobTitleList.Items.Add("Technical Product Manager");
                        jobTitleList.Items.Add("Market Research Analyst");
                        break;
                    case "Engineering":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Software Engineer");
                        jobTitleList.Items.Add("DevOps Engineer");
                        jobTitleList.Items.Add("Site Reliability Engineer (SRE)");
                        jobTitleList.Items.Add("Quality Assurance Engineer");
                        jobTitleList.Items.Add("Systems Engineer");
                        jobTitleList.Items.Add("Front-end Developer");
                        jobTitleList.Items.Add("Back-end Developer");
                        jobTitleList.Items.Add("Full-stack Developer");
                        jobTitleList.Items.Add("Mobile App Developer");
                        jobTitleList.Items.Add("Database Administrator (DBA)");
                        jobTitleList.Items.Add("Software Architect");
                        jobTitleList.Items.Add("Automation Tester");
                        break;
                    case "Research and Development (R&D)":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Research Scientist");
                        jobTitleList.Items.Add("Machine Learning Engineer");
                        jobTitleList.Items.Add("AI Reseracher");
                        jobTitleList.Items.Add("Hardware Engineer");
                        jobTitleList.Items.Add("Embedded Systems Engineer");
                        break;
                    case "Information Technology (IT)":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("IT Manager");
                        jobTitleList.Items.Add("Systems Administrator");
                        jobTitleList.Items.Add("Network Administrator");
                        jobTitleList.Items.Add("Technical Support Specialist");
                        jobTitleList.Items.Add("IT Support Technician");
                        jobTitleList.Items.Add("Help Desk Technician");
                        jobTitleList.Items.Add("Cloud Architect");
                        break;
                    case "Data Science and Analytics":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Data Analyst");
                        jobTitleList.Items.Add("Data Engineer");
                        jobTitleList.Items.Add("Business Intelligence Analyst");
                        jobTitleList.Items.Add("Data Scientist");
                        jobTitleList.Items.Add("Machine Learning Specialist");
                        jobTitleList.Items.Add("Statistician");
                        jobTitleList.Items.Add("Data Visualisation Specialist");
                        break;
                    case "User Experience (UX) and User Inteface (UI)":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("UX Researcher");
                        jobTitleList.Items.Add("UX Designer");
                        jobTitleList.Items.Add("UI Designer");
                        jobTitleList.Items.Add("Interaction Designer");
                        jobTitleList.Items.Add("Usability Tester");
                        jobTitleList.Items.Add("Information Architect");
                        jobTitleList.Items.Add("Visual Designer");
                        break;
                    case "Sales and Business Development":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Sales Executive");
                        jobTitleList.Items.Add("Account Manager");
                        jobTitleList.Items.Add("Business Development Manager");
                        jobTitleList.Items.Add("Sales Engineer");
                        jobTitleList.Items.Add("Territory Sales Engineer");
                        jobTitleList.Items.Add("Inside Sales Manager");
                        jobTitleList.Items.Add("Outside Sales Manager");
                        break;
                    case "Marketing":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Marketing Manager");
                        jobTitleList.Items.Add("Digital Marketing Specialist");
                        jobTitleList.Items.Add("Content Marketing Manager");
                        jobTitleList.Items.Add("Social Media Manager");
                        jobTitleList.Items.Add("SEO Specialist");
                        jobTitleList.Items.Add("Email Marketing Specialist");
                        jobTitleList.Items.Add("Marketing Analyst");
                        jobTitleList.Items.Add("Brand Manager");
                        jobTitleList.Items.Add("Graphic Designer");
                        break;
                    case "Customer Support":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Customer Support Representative");
                        jobTitleList.Items.Add("Customer Success Manager");
                        jobTitleList.Items.Add("Technical Support Specialist");
                        jobTitleList.Items.Add("Customer Experience Specialist");
                        jobTitleList.Items.Add("Help Desk Specialist");
                        break;
                    case "Cybersecurity":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Security Analyst");
                        jobTitleList.Items.Add("Information Security Analyst");
                        jobTitleList.Items.Add("Cybersecurity Engineer");
                        jobTitleList.Items.Add("Cybersecurity Analyst");
                        jobTitleList.Items.Add("Security Consultant");
                        jobTitleList.Items.Add("Incident Response Specialist");
                        jobTitleList.Items.Add("Compliance Officer");
                        break;
                    case "Legal Compliance":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Legal Counsel");
                        jobTitleList.Items.Add("Compliance Manager");
                        jobTitleList.Items.Add("Contract Manager");
                        jobTitleList.Items.Add("Intellectual Property (IP) Attourney");
                        jobTitleList.Items.Add("Privacy Officer");
                        jobTitleList.Items.Add("Corporate Paralegal");
                        break;
                    case "Human Resources (HR)":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("HR Manager");
                        jobTitleList.Items.Add("HR Generalist");
                        jobTitleList.Items.Add("Recruitment Specialist");
                        jobTitleList.Items.Add("Talent Acquisition Manager");
                        jobTitleList.Items.Add("Training and Development Manager");
                        jobTitleList.Items.Add("Compensation and Benefits Analyst");
                        jobTitleList.Items.Add("Employee Relations Specialist");
                        break;
                    case "Technical Writing":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Technical Writer");
                        jobTitleList.Items.Add("Documentation Specialist");
                        jobTitleList.Items.Add("Content Developer");
                        jobTitleList.Items.Add("Instructional Writer");
                        jobTitleList.Items.Add("User Experience Writer");
                        break;
                    case "Operations":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Operations Manager");
                        jobTitleList.Items.Add("Project Manager");
                        jobTitleList.Items.Add("Program Manager");
                        jobTitleList.Items.Add("Supply Chain Manager");
                        jobTitleList.Items.Add("Logistics Coordinator");
                        break;
                    case "Cloud Services/Infrastructure":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Cloud Solutions Architect");
                        jobTitleList.Items.Add("Cloud Engineer");
                        jobTitleList.Items.Add("Cloud Systems Administrator");
                        jobTitleList.Items.Add("Cloud Systems Specialist");
                        jobTitleList.Items.Add("Cloud Consultant");
                        break;
                    case "Corporate Social Responsibility (CSR)":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("CSR Manager");
                        jobTitleList.Items.Add("Sustainability Officer");
                        jobTitleList.Items.Add("Community Engagement Coordinator");
                        break;
                    case "Event Management":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Event Manager");
                        jobTitleList.Items.Add("Event Coordinator");
                        jobTitleList.Items.Add("Conference Planner");
                        jobTitleList.Items.Add("Trade Show Manager");
                        break;
                    case "Training and Development":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Training Manager");
                        jobTitleList.Items.Add("Learning and Development Specialist");
                        jobTitleList.Items.Add("Corporate Trainer");
                        jobTitleList.Items.Add("eLearning Developer");
                        break;
                    case "Technical Support":
                        jobTitleList.Items.Add("-Select Job Title-");
                        jobTitleList.Items.Add("Technical Support Specialist");
                        jobTitleList.Items.Add("Support Engineer");
                        jobTitleList.Items.Add("Technical Account Manager");
                        break;
                }
            }
        }

        private void computeSalary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameText.Text) ||
                string.IsNullOrWhiteSpace(lastNameText.Text) ||
                departmentList.SelectedItem == null ||
                jobTitleList.SelectedItem == null ||
                string.IsNullOrWhiteSpace(ratePerHourText.Text) ||
                string.IsNullOrWhiteSpace(totalHoursWorkedText.Text))
            {
                MessageBox.Show("Please fill out all fields to compute salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal HourlyRate;
            if (!decimal.TryParse(ratePerHourText.Text, out HourlyRate))
            {
                MessageBox.Show("Rate per hour must be a real number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ratePerHourText.Clear();
                return;
            }

            int HoursWorked;
            if (!int.TryParse(totalHoursWorkedText.Text, out HoursWorked))
            {
                MessageBox.Show("Total hours worked must be a real number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalHoursWorkedText.Clear();
                return;
            }

            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;
            string department = departmentList.SelectedItem.ToString();
            string jobTitle = jobTitleList.SelectedItem.ToString();
            decimal hourlyRate = Convert.ToDecimal(ratePerHourText.Text);
            int hoursWorked = Convert.ToInt32(totalHoursWorkedText.Text);

            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle, hourlyRate, hoursWorked);

            returnFirstName.Text = firstName;
            returnLastName.Text = lastName;
            decimal salary = employee.ComputeSalary();
            returnBasicSalary.Text = $"{salary:C}";
        }

        private void clearInput_Click(object sender, EventArgs e)
        {
            firstNameText.Clear();
            lastNameText.Clear();
            departmentList.SelectedIndex = -1;
            jobTitleList.SelectedIndex = -1;
            ratePerHourText.Clear();
            totalHoursWorkedText.Clear();
            returnFirstName.Text = "<first name here>";
            returnLastName.Text = "<last name here>";
            returnBasicSalary.Text = "00.00";
        }
    }
}