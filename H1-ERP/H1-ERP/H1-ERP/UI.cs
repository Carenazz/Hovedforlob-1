using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP
{
    public class UI
    {
        // Prints out text - Similar to writeline
        public void WriteText(string info)
        {
            Console.WriteLine(info);
        }

        // Gets input from user in the form of a string.
        public string GetStringFromUser(string info)
        {
            string getString;
            Console.WriteLine(info);
            getString = Console.ReadLine();
            return getString;
        }

        // Gets input from the user and checks if it is only numbers.
        public int GetIntFromUser(string info)
        {
            string userInput;
            Console.WriteLine(info);
            do
            {
                userInput = Console.ReadLine();
            } while (IsValidNumber(userInput));
            return Convert.ToInt32(userInput);
        }

        public void GetMenu(string header,string menuChoices)
        {
            Menu menu = new Menu();
            WriteText(header);
            WriteText(menuChoices);
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    menu.CustomerMenu();
                    break;
                case "2":
                    menu.ItemMenu();
                    break;
                default:
                    WriteText("Isn't a valid choice in the menu");
                    break;
            }
        }

        // Checks if the string is only numbers and isn't null.
        private bool IsValidNumber(string check)
        {
            if (check.All(char.IsDigit) && !string.IsNullOrWhiteSpace(check))
                return true;
            else
                Console.WriteLine("Is not a valid number, try again.");
                return false;
        }
        public bool Test(string check)
        {
            return IsValidNumber(check);
        }
    }
}
