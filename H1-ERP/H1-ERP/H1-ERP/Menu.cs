using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP
{
    class Menu
    {
        UI ui = new UI();
        Inventory inv = new Inventory();
        
        // A menu for customers, viewing, selecting and adding items to a cart.
        public void CustomerMenu()
        {
            ui.WriteText("1: View items \n2: Select an item \n3: Remove an item from the cart \n4: Checkout\n" +
                "Select an option:");
            int check = ui.GetIntFromUser(Console.ReadLine());
            switch (check)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        // A menu over the item options and items.
        public void ItemMenu()
        {
            do
            {
                int check = ui.GetIntFromUser("1: View an item \n2: Create an item \n3: Modify an item \n4: Remove an item\n" +
                    "Select an option:");
                switch (check)
                {
                    case 1:
                        foreach (var item in Inventory.invList)
                        {
                            Console.WriteLine(new String('-', 25));
                            Console.WriteLine($"|{item.ItemID}\t{item.ItemName}\t{item.ItemPrice}\t{item.ItemQuantity}|");
                            Console.WriteLine(new String('-', 25));
                        }
                        break;
                    case 2:
                        string itemName = ui.GetStringFromUser("Write the name of the item: ");
                        int itemQuantity = ui.GetIntFromUser("What's the items quantity: ");
                        double itemPrice = ui.GetDoubleFromUser("What's the item's price (Cannot be 0 or lower): ");
                        Inventory.invList.Add(new Item(itemName, itemQuantity, itemPrice));
                        break;
                    case 3:
                        break;
                    case 4:
                        Inventory.invList.RemoveAt(ui.GetIntFromUser("What do you want to remove?: ") - 1);
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
