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
        private Trivia CatTrivia;
        private Trivia FrogTrivia;
        private Trivia MonkeyTrivia;
        private Trivia OtterTrivia;
        private Trivia SlothTrivia;
        private Trivia PenguinTrivia;
        private Trivia CapybaraTrivia;
        public Game() 
        {
            string pufferfishQuestion = "This spikey boi inlates when threatened. - Clownfish, Pufferfish, Shark, Ocean Sunfish";
            pufferfishTrivia = new Trivia(pufferfishQuestion, "Pufferfish");
            
            string CatQuestion = "This small wildcat is native to the mountainous regions across Cental Asia. - Caracal, Tiger, Palla's Cat, Serval";
            CatTrivia = new Trivia(CatQuestion, "Palla's Cat");

            string FrogQuestion = "These spicy boys are the most toxic species of frog - Poison Dart Frog, Golden Poison Frog, Pacman Frog, Budgetts Frog";
            FrogTrivia = new Trivia(FrogQuestion, "Golden Poison Frog");

            string MonkeyQuestion = "This small cute monkey is in the movie Madagascar - Tamarin, Golden Lion Monkey, Bushbaby, Spider Monkey";
            MonkeyTrivia = new Trivia(MonkeyQuestion, "Bushbaby");

            string OtterQuestion = "These friendly animals love companionship, and often swim in pairs - Otter, Seal, Muskrat, Dog";
            OtterTrivia = new Trivia(OtterQuestion, "Otter");

            string SlothQuestion = "Without the help of these animals, we would not have avocados - Bear, Sloth, Lemur, Koala";
            SlothTrivia = new Trivia(SlothQuestion, "Sloth");

            string PenguinQuestion = "Popular in Japanese zoos, this cowardly penguin is native to South America - Royal, Emperor, Humbolt, Giant";
            PenguinTrivia = new Trivia(PenguinQuestion, "Humbolt");

            string CapybaraQuestion = "The largest species of rodent, UrbanRescueRanch has two named Gort and Quandale - Prarie Dog, Hamster, Gerbil, Capybara";
            CapybaraTrivia = new Trivia(CapybaraQuestion, "Capybara");




        }
        public void Play()
        {
            Title = GameTitle;

            //this is a frog
            ForegroundColor = ConsoleColor.Green;
            WriteLine("     _e-e_  ");
            WriteLine("    (-._.-)  ");
            WriteLine(".-(  `---'  )-.");
            WriteLine(" __\\ \\\\\\___/// /__");
            WriteLine("'-._.'/M\\ /M\\`._,-");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Welcome to Cristina's Trivia Game");
            WriteLine("Press any key to begin");
            ReadKey();
            Clear();

            WriteLine("Hello player, What is your name? ");
            String PlayerName = ReadLine();
            CurrentPlayer = new Player(PlayerName);
            WriteLine("Hello there, " + PlayerName);
            WriteLine("Your starting score is " + CurrentPlayer.Score);
            ReadKey();
            Clear();

            pufferfishTrivia.AskQuestion();
            Clear();
            CatTrivia.AskQuestion();
            FrogTrivia.AskQuestion();
            MonkeyTrivia.AskQuestion();
            OtterTrivia.AskQuestion();
            SlothTrivia.AskQuestion();
            PenguinTrivia.AskQuestion();
            CapybaraTrivia.AskQuestion();

            WriteLine("Press any key to begin");
            ReadKey();
        }
    }
}
