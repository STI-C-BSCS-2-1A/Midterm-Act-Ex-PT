using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class DiscountedItem : Item
    {
        private double itemDiscount;
        private double discountedPrice;
        private double paymentAmount;
        private double change;

        public DiscountedItem(string item, double price, int quantity,  double discount) : base(item, price, quantity)
        {
            this.itemDiscount = discount;
        }

        public override double getTotalPrice()
        {
            double percentFormula = itemDiscount * 0.01;
            double priceWithoutDiscount = itemPrice * itemQuantity;
            double totalWithDiscount = priceWithoutDiscount * percentFormula;

            discountedPrice = priceWithoutDiscount - totalWithDiscount;
            return discountedPrice;
        }

        public override void setPayment(double amount)
        {
            paymentAmount = amount;
            change = paymentAmount - getTotalPrice();
        }

        public double getChange()
        {
            return change;
        }
    }
}