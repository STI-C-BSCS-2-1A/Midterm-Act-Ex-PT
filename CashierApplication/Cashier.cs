using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string uName, string password, string department) : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            return uName == userName && password == userPassword;
        }

        public string getDepartment()
        {
            return department;
        }
    }
}
