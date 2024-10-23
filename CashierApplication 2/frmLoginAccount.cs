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
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Cashier user = new Cashier("Steven Dizon", "zephyrine", "1234", "Finance");

            if (string.IsNullOrWhiteSpace(usernameText.Text) ||
                string.IsNullOrWhiteSpace(passwordText.Text))
            {
                MessageBox.Show("Please fill out all the fields before logging in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usernameInput = usernameText.Text;
            string passwordInput = passwordText.Text;

            if(user.validateLogin(usernameInput, passwordInput))
            {
                string fullName = user.getFullName();
                string department = user.getDepartment();
                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem(fullName, department);
                purchaseForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameText.Clear();
                passwordText.Clear();
                return;
            }
        }
    }
}