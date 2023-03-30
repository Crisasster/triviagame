using System;

namespace CristinasTriviaGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game currentGame = new Game();
            currentGame.Play();

            bool keepPlaying = true;
            while (keepPlaying)
            {
                currentGame.Play();

                keepPlaying = Console.ReadKey().Key.ToString().ToUpper().Equals("Yes");


                Console.WriteLine("Would you like to play again? - Yes or No)");
                string CurrentGame = "";
                while (CurrentGame != "stop")
                return;
            }
    }
    }
    }
