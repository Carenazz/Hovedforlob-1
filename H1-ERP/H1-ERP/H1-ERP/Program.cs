using System;
using System.Collections.Generic;

namespace H1_ERP
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            Item item = new Item(1, "Banana", 50, 0.99);
            ui.GetMenu("Welcome to the main menu ", "1: Customers \n2: Items \nSelect an option: ");

            List<Inventory> inv = new List<Inventory>();
        }
    }
}
