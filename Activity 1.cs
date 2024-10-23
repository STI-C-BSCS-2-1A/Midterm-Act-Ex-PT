namespace UserNamespace
{
    class Act1
    {
        static void Main()
        {
            Administrator admin = new Administrator("Steven Dizon", "steve123", "Act1");
            bool login = admin.verifyLogin("steve123", "Act1");

            admin.updatePassword("Act2");
            bool login2 = admin.verifyLogin("steve123", "Act2");

            Console.Write($"{login}\n{login2}");
        }
    }

    abstract class User
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
        public abstract void updatePassword(string newPassword);
    }

    class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }
        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }
        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }
    }
}