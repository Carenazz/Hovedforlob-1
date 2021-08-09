using System;

namespace GætEtTal
{
    class Program
    {
        static void Main(string[] args)
        {
            // En region bare fordi jeg kan.. Og til at sætte det mere struktureret.
            #region Instanstieringer af klasser
            Game tal = new();
            GUI gui = new();
            Player player = new();
            #endregion

            int guess, maxNum;
            
            // Objekt fra player og gui klassen for at indtaste og printe navnet ud.
            player.Name = gui.GetStringFromUser("What's your name? ");
            gui.WriteText("Hello " + player.Name);
            

            // Do / While for om at brugeren vil fortsætte med at spille (I et nyt spil)
            do
            {
                // Input fra user med valg af højeste nummer som random number generatoren skal gå til.
                maxNum = gui.GetIntFromUser("What should the highest number be? ");
                tal.CreateRandomNumber(maxNum);

                // DO / While for at blive ved med at spørge useren om at gætte et tal, indtil det er gættet.
                do
                {
                    // Input fra user, gæt et tal.
                    guess = gui.GetIntFromUser("Guess a number ");

                    // Checker og giver svar på om tallet er korrekt, højere eller lavere.
                    if (guess == tal.myNumber)
                    {
                        gui.WriteText("Correct!");
                        tal.Guessed(guess);
                    }
                    else if (guess < tal.myNumber)
                    {
                        gui.WriteText("Higher!");
                    }
                    else
                    {
                        gui.WriteText("Lower!");
                    }

                } while (!tal.Guessed(guess));

            } while (Continue());

            gui.WriteText("Thanks " + player.Name + " for using Mike's Guess Number Application");
        }

        static bool Continue()
        {
            GUI gui = new();
            string check;
            
            // Input fra useren om at de vil fortsætte og checker om de har tastet y eller andet.
            check = gui.GetStringFromUser("Do you want to continue? Y / N: ");
            if (check.ToLower() == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
