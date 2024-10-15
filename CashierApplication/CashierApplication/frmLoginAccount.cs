using CashierApplication.UserAccountNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;

        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            
            cashier = new Cashier("Sico", "Admin", "jsico", "admin123");

           
            if (cashier.validateLogin(UNametxt.Text, Passwordtxt.Text))
            {
               
                MessageBox.Show("Login Successful! Welcome " + cashier.getFullName());

                
                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem(cashier);
                this.Hide();
                purchaseForm.Show();
            }
            else
            {
                
                MessageBox.Show("Invalid Username or Password!");
            }

        }
    }
    namespace UserAccountNamespace
    {
        public class UserAccount
        {
            private string full_name;
            private string user_name;
            protected string user_password;

           
            public UserAccount(string fullName, string uName, string password)
            {
                this.full_name = fullName;
                this.user_name = uName;
                this.user_password = password;
            }

            public bool validateLogin(string uName, string password)
            {
                return this.user_name == uName && this.user_password == password;
            }

            public string getFullName()
            {
                return this.full_name;
            }
        }

        public class Cashier : UserAccount
        {
            private string department;

            
            public Cashier(string fullName, string department, string uName, string password)
                : base(fullName, uName, password)
            {
                this.department = department;
            }

            public string getDepartment()
            {
                return this.department;
            }
        }
    }
}


