using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class UserAccount
    {
        private string fullName;
        protected string userName;
        protected string userPassword;

        public UserAccount(string name, string uName, string password)
        {
            this.fullName = name;
            this.userName = uName;
            this.userPassword = password;
        }

        public abstract bool validateLogin(string uName, string password);

        public string getFullName()
        {
            return fullName;
        }
    }
}
