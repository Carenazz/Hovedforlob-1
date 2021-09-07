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
        public void CustomerMenu()
        {
            ui.WriteText("");
        }

        public void ItemMenu()
        {
            ui.WriteText("1: Select an item \n2: Create an item \n3: Modify an item \n4: Remove an item");
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
