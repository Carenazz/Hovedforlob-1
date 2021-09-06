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
            itemID = ID;
            itemName = name;
            itemQuantity = quantity;
            itemPrice = price;
        }

        public void Print()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("ID: " + itemID +
                              "\nName: " + itemName +
                              "\nQuantity: " + itemQuantity +
                              "\nPrice: " + itemPrice);
        }
    }
}
