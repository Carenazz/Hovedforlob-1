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
            Inventory.invList.Add(new Item("Banana", 50, 0.99));
            Inventory.invList.Add(new Item("Apple", 50, 1.99));
            Inventory.invList.Add(new Item("Pear", 50, 9));
            inv.PrintTable();
            ui.GetMenu("Welcome to the main menu ", "1: Customers \n2: Items \nSelect an option: ");

        }
    }
}
