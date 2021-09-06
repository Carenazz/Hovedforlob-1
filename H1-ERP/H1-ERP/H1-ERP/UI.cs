using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP
{
    public class UI
    {
        public void WriteText(string info)
        {
            Console.WriteLine(info);
        }

        public string GetStringFromUser(string info)
        {
            string getString;
            Console.WriteLine(info);
            getString = Console.ReadLine();
            return getString;
        }

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
            WriteText(header);
            WriteText(menuChoices);
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;

                default:
                    WriteText("Isn't a valid choice in the menu");
                    break;
            }
        }


        private bool IsValidNumber(string check)
        {
            if (check.All(char.IsDigit) && !string.IsNullOrWhiteSpace(check))
                return true;
            else
                Console.WriteLine("Is not a valid number, try again.");
                return false;
        }
    }
}
