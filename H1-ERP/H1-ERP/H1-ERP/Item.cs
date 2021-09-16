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
        static private int nextItemID = 1;
        int itemQuantity;
        double itemPrice;

        public Item()
        {
            nextItemID++;
        }

        // Item constructor class, when making an item.
        public Item(string name, int quantity, double price)
        {
            itemID = nextItemID;
            ItemName = name;
            ItemQuantity = quantity;
            ItemPrice = price;
            nextItemID++;
        }

        // Prints out the items, ID, name, quantity and price.
        public void Print()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("ID: " + itemID +
                              "\nName: " + ItemName +
                              "\nQuantity: " + ItemQuantity +
                              "\nPrice: " + ItemPrice);
        }

        // Properties for the item variables.
        public int ItemID
        {
            get { return itemID; }
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
            set
            {
                itemQuantity = value;
            }
        }
        public double ItemPrice
        {
            get { return itemPrice; }
            set
            {
                if (value != 0)
                {
                    itemPrice = value;
                }
            }
        }
    }
}
