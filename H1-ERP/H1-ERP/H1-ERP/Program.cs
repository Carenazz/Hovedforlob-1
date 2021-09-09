using System;
using System.Collections.Generic;

namespace H1_ERP
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            Inventory inv = new Inventory();
            Item item = new Item(1, "Banana", 50, 0.99);
            Item item2 = new Item(2, "Apple", 50, 1.99);
            inv.PrintTable();
            Inventory.invList.Add(new Item(3, "Pear", 50, 9));
            ui.GetMenu("Welcome to the main menu ", "1: Customers \n2: Items \nSelect an option: ");

        }
    }
}
