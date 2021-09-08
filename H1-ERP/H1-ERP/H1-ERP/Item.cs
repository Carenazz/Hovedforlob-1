using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP
{
    public class Item : Inventory
    {
        string itemName;
        private int itemID = 1; 
        protected int itemQuantity;
        double itemPrice;

        public Item()
        {
            itemID++;
        }

        public Item(int ID, string name, int quantity, double price)
        {
            itemID = ID;
            ItemName = name;
            ItemQuantity = quantity;
            ItemPrice = price;
            itemID++;
        }

        public void Print()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("ID: " + itemID +
                              "\nName: " + ItemName +
                              "\nQuantity: " + ItemQuantity +
                              "\nPrice: " + ItemPrice);
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
            }
        }

        public int ItemQuantity
        {
            get { return itemQuantity; }
            protected set
            {
                itemQuantity = value;
            }
        }
        public double ItemPrice
        {
            get { return itemPrice; }
            protected set
            {
                if (value != 0)
                {
                    itemPrice = value;
                }
            }
        }
    }
}
