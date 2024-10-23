using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class Item
    {
        protected string itemName;
        protected double itemPrice;
        protected int itemQuantity;
        private double totalPrice;

        public Item(string item, double price, int quantity)
        {
            this.itemName = item;
            this.itemPrice = price;
            this.itemQuantity = quantity;
        }
        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }
}