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
        int itemID, itemQuantity;
        double itemPrice;

        public Item()
        {

        }

        public Item(int ID, string name, int quantity, double price)
        {
            ItemID = ID;
            ItemName = name;
            ItemQuantity = quantity;
            ItemPrice = price;
        }

        public void Print()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("ID: " + ItemID +
                              "\nName: " + ItemName +
                              "\nQuantity: " + ItemQuantity +
                              "\nPrice: " + ItemPrice);
        }

        public int ItemID
        {
            get;
            private set;
        }

        public string ItemName
        {
            get;
            set;
        }

        public int ItemQuantity
        {
            get;
            protected set;
        }
        public double ItemPrice
        {
            get;
            protected set;
        }
    }
}
