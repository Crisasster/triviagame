using System;

namespace CristinasTriviaGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game currentGame = new Game();
            currentGame.Play();

            //loop goes here

            bool keepPlaying = true;
            while (keepPlaying)
            {


                keepPlaying = Console.ReadKey().Key.ToString().ToUpper().Equals("Yes");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("        ^-----^   ");
                Console.WriteLine("      _.| o o | _   ) ) ");
                Console.WriteLine("    -(((---(((--------  ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thank you for playing!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Would you like to play again? - Yes or No ");
                Console.ResetColor();
                Console.ReadLine();
                currentGame.Play();

            }
        }
    }
}
