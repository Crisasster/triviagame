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
        private Player CurrentPlayer;
        readonly private Trivia PufferfishTrivia;
        readonly private Trivia CatTrivia;
        readonly private Trivia FrogTrivia;
        readonly private Trivia MonkeyTrivia;
        readonly private Trivia OtterTrivia;
        readonly private Trivia SlothTrivia;
        readonly private Trivia PenguinTrivia;
        readonly private Trivia CapybaraTrivia;
        readonly private Trivia BirdTrivia;
        readonly private Trivia AxolotlTrivia;
        public Game() 
        {

            string PufferfishQuestion = "This spikey boi inlates when threatened. - Clownfish, Pufferfish, Shark, Ocean Sunfish";
            PufferfishTrivia = new Trivia(PufferfishQuestion, "Pufferfish");
            
            string CatQuestion = "This small wildcat is native to the mountainous regions across Cental Asia. - Caracal, Tiger, Palla's Cat, Serval";
            CatTrivia = new Trivia(CatQuestion, "Palla's Cat");

            string FrogQuestion = "These spicy boys are the most toxic species of frog. - Poison Dart Frog, Golden Poison Frog, Pacman Frog, Budgetts Frog";
            FrogTrivia = new Trivia(FrogQuestion, "Golden Poison Frog");

            string MonkeyQuestion = "This small cute monkey is in the movie Madagascar. - Tamarin, Golden Lion Monkey, Galago, Spider Monkey";
            MonkeyTrivia = new Trivia(MonkeyQuestion, "Galago");

            string OtterQuestion = "These friendly animals love companionship, and often swim in pairs. - Otter, Seal, Muskrat, Dog";
            OtterTrivia = new Trivia(OtterQuestion, "Otter");

            string SlothQuestion = "Without the help of these animals, we would not have avocados. - Bear, Sloth, Lemur, Koala";
            SlothTrivia = new Trivia(SlothQuestion, "Sloth");

            string PenguinQuestion = "Popular in Japanese zoos, this cowardly penguin is native to South America. - Royal, Emperor, Humbolt, Giant";
            PenguinTrivia = new Trivia(PenguinQuestion, "Humbolt");

            string CapybaraQuestion = "The largest species of rodent, UrbanRescueRanch has two named Gort and Quandale. - Prarie Dog, Hamster, Gerbil, Capybara";
            CapybaraTrivia = new Trivia(CapybaraQuestion, "Capybara");

            string BirdQuestion = "Native to Australia, these birds are known for their calls which sounds like laughs. - Cockatoo, kookaburra, Lorikeet, Lyrebird";
            BirdTrivia = new Trivia(BirdQuestion, "Kookaburra");

            string AxolotlQuestion = "This popular series of salamander does not go through metamorphosis. - Axolotl, Newt, Mole, Siren";
            AxolotlTrivia = new Trivia(AxolotlQuestion, "Axolotl");


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
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Welcome to Cristina's Trivia Game!");
            WriteLine("To play, type in the answer you belive is correct.");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Press any key to begin");
            ReadKey();
            Clear();

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Hello player, What is your name? ");
            String PlayerName = ReadLine();
            ForegroundColor = ConsoleColor.Blue;
            CurrentPlayer = new Player(PlayerName);
            WriteLine("Hello there, " + PlayerName);
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("Your starting score is " + CurrentPlayer.Score);
            ResetColor();
            ReadKey();
            Clear();


            PufferfishTrivia.AskQuestion();
            CatTrivia.AskQuestion();
            FrogTrivia.AskQuestion();
            MonkeyTrivia.AskQuestion();
            OtterTrivia.AskQuestion();
            SlothTrivia.AskQuestion();
            PenguinTrivia.AskQuestion();
            CapybaraTrivia.AskQuestion();
            BirdTrivia.AskQuestion();
            AxolotlTrivia.AskQuestion();

                ReadKey();

            }
        }
    }

