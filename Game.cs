using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CristinasTriviaGame1
{
    internal class Game
    {
        private string GameTitle = "Cristina's Trivia Game";
        private string Description = "This Trivia game features fun facts about animals";
        private Player CurrentPlayer;
        private Trivia pufferfishTrivia;
        public Game() 
        {
            string pufferfishQuestion = "This spikey boi inlates when threatened. - Clownfish, Pufferfish, Shark, Ocean Sunfish";
            pufferfishTrivia = new Trivia(pufferfishQuestion, "Pufferfish");
        }
        public void Play()
        {
            Title = GameTitle;

            WriteLine("Welcome to Cristina's Trivia Show");
            WriteLine("\nWhat is your name? ");
            String PlayerName = ReadLine();
            CurrentPlayer = new Player(PlayerName);
            WriteLine("You said " + PlayerName);
            WriteLine("Your starting score is " + CurrentPlayer.Score);

            pufferfishTrivia.AskQuestion();

            WriteLine("Press any key to begin");
            ReadKey();
        }
    }
}
