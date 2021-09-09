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
            ui.WriteText("1: Select an item \n2: Create an item \n3: Modify an item \n4: Remove an item\n" +
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
    }
}
