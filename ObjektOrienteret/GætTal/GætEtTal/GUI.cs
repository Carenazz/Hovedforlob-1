using System;
using System.Linq;

namespace GætEtTal
{
    class GUI
    {
        // Giver useren en besked om hvad de skal og modtage input i form af en string.
        public string GetStringFromUser(string guide)
        {
            Console.Write(guide);
            string input = "";
            input = Console.ReadLine();
            return input;
        }

        // Giver useren en besked om hvad de skal og modtage input i form af en int.. DO / WHILE til at sikre sig at det er et tal.
        public int GetIntFromUser(string guide)
        {
            string input;
            Console.Write(guide);
            do
            {
                input = Console.ReadLine();
            } while (!IsANumber(input));
            return Convert.ToInt32(input);
        }

        // Skriver en tekst ud.
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }

        // Var planlagt, men ikke 
        public void ContinueChoice()
        {
            Console.WriteLine("Want to continue using the application? Y / N");
        }

        private bool IsANumber(string check)
        {
            if (check.All(char.IsDigit) && !string.IsNullOrWhiteSpace(check))
            {
                return true;
            }
            else
            {
                WriteText("Is not a number, try again ");
                return false;
            }
        }
    }
}
