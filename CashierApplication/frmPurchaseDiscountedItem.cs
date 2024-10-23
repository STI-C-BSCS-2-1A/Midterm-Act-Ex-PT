namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private double totalAmountValue = 0;
        private DiscountedItem currentItem;
        private string fullName;
        private string department;
        public frmPurchaseDiscountedItem(string fullName, string department)
        {
            InitializeComponent();
            this.fullName = fullName;
            this.department = department;

            MessageBox.Show($"Welcome {fullName} of {department}");
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(itemText.Text) ||
                string.IsNullOrWhiteSpace(priceText.Text) ||
                string.IsNullOrWhiteSpace(quantityText.Text) ||
                string.IsNullOrWhiteSpace(discountText.Text))
            {
                MessageBox.Show("Please fill out all the fields before computing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double price;
            if (!double.TryParse(priceText.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                priceText.Clear();
                return;
            }

            int quantity;
            if (!int.TryParse(quantityText.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantityText.Clear();
                return;
            }

            double discount;
            if (!double.TryParse(discountText.Text, out discount) || discount < 0)
            {
                MessageBox.Show("Please enter a valid discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                discountText.Clear();
                return;
            }

            currentItem = new DiscountedItem(itemText.Text, price, quantity, discount);

            totalAmountValue = currentItem.getTotalPrice();

            totalAmount.Text = $"{totalAmountValue:C2}";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paymentReceivedText.Text))
            {
                MessageBox.Show("Please enter your payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentReceivedText.Clear();
                return;
            }

            double payment;
            if (!double.TryParse(paymentReceivedText.Text, out payment))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentReceivedText.Clear();
                return;
            }

            currentItem.setPayment(payment);
            double change = payment - totalAmountValue;
            if (change < 0)
            {
                MessageBox.Show("Please enter an amount more than the total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentReceivedText.Clear();
                return;
            }
            Change.Text = $"{change:C2}";
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();

            this.Close();
        }

        private void exitApplicationMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}