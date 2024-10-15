using CashierApplication.UserAccountNamespace;

namespace CashierApplication
{

    public partial class frmPurchaseDiscountedItem : Form
    {
        private Cashier cashier;

        public frmPurchaseDiscountedItem(Cashier cashier)
        {
            InitializeComponent();
            this.cashier = cashier;

            MessageBox.Show("Welcome " + cashier.getFullName() + " of " + cashier.getDepartment() + ".",
                             "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            this.Hide();
            loginForm.Show();
        }


        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();

        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {

            string itemName = Itemtxt.Text;
            double Price = Convert.ToDouble(Pricetxt.Text);
            double Discount = Convert.ToDouble(Discounttxt.Text) * 0.01;
            int Quantity = Convert.ToInt32(Quantitytxt.Text);


            ItemNamespace.DiscountedItem discountedItem = new ItemNamespace.DiscountedItem(itemName, Price, Quantity, Discount);

            TotalAmountlbl.Text = discountedItem.getDiscountedPrice().ToString("F2");
        }

        private void SubmitBtn_Click(Object sender, EventArgs e)
        {

            double paymentReceived = Convert.ToDouble(PaymentReceivedtxt.Text);


            string itemName = Itemtxt.Text;
            double Price = Convert.ToDouble(Pricetxt.Text);
            double Discount = Convert.ToDouble(Discounttxt.Text) * 0.01;
            int Quantity = Convert.ToInt32(Quantitytxt.Text);


            ItemNamespace.DiscountedItem discountedItem = new ItemNamespace.DiscountedItem(itemName, Price, Quantity, Discount);

            discountedItem.setPayment(paymentReceived);

            Changelbl.Text = discountedItem.getChange().ToString("F2");

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            this.Hide();
            loginForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

namespace ItemNamespace
{
    public class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        protected double total_price;

        public Item(string name, double price, int quantity)
        {

            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
            this.total_price = price * quantity;  

        }

        public double getTotalPrice()
        {

            return this.total_price;

        }
    }

    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {

            this.item_discount = discount;
            this.discounted_price = this.total_price - (this.total_price * this.item_discount);

        }

        public double getDiscountedPrice()
        {

            return this.discounted_price;

        }

        public void setPayment(double amount)
        {

            this.payment_amount = amount;
            this.change = this.payment_amount - this.discounted_price;

        }

        public double getChange()
        {

            return this.change;

        }
    }
}