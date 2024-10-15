using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    
    public class User
    {
        
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        
        public bool verifyLogin(string id, string pass)
        {
            return this.user_id.Equals(id) && this.user_password.Equals(pass);
        }

       
        public virtual void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
            Console.WriteLine("Password updated successfully.");
        }
    }

    
    public class Administrator : User
    {
        
        private string admin_name;

       
        public Administrator(string name, string id, string pass)
            : base(id, pass)
        {
            this.admin_name = name;
        }

       
        public override void updatePassword(string newPassword)
        {
            base.updatePassword(newPassword);
            Console.WriteLine("Password updated.");
        }

        
        public void updateAdminName(string name)
        {
            this.admin_name = name;
            Console.WriteLine("Administrator name update: " + this.admin_name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User("NewAcc", "password123");
            Console.WriteLine(user.verifyLogin("NewAcc", "password123"));  
          
            Administrator admin = new Administrator("Admin1", "admin123", "adminpass");
            admin.updatePassword("newadminpass");  
            admin.updateAdminName("NewAdmin");     
        }
    }
}
