using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GætEtTal
{
    class Game
    {
        public int myNumber;
        Die sides = new Die();
        GUI gui = new();

        // Laver et random nummer ud fra input som max.
        public int CreateRandomNumber(int howMany)
        {
            Random random = new Random();
            myNumber = random.Next(sides.Dice(howMany));

            return myNumber;
        }

        // Checker om gættet er rigtigt eller falsk.
        public bool Guessed(int guess)
        {
            if (myNumber == guess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // (Sat over til program, har ingen referneces)
        public void IsCorrect(int guess)
        {
            if (myNumber == guess)
            {
                gui.WriteText("You guessed correctly!");
            }
            else if (myNumber < guess)
            {
                gui.WriteText("You need to guess higher");
            }
            else
            {
                gui.WriteText("You need to guess lower");
            }
        }
    }
}
