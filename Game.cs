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
            //questions and answers go here
            string PufferfishQuestion = "1. This spikey boi inlates when threatened. - Clownfish, Pufferfish, Shark, Ocean Sunfish";
            PufferfishTrivia = new Trivia(PufferfishQuestion, "Pufferfish");
            
            string CatQuestion = "2. This small wildcat is native to the mountainous regions across Cental Asia. - Caracal, Tiger, Palla's Cat, Serval";
            CatTrivia = new Trivia(CatQuestion, "Palla's Cat");

            string FrogQuestion = "3. These spicy boys are the most toxic species of frog. - Poison Dart Frog, Golden Poison Frog, Pacman Frog, Budgetts Frog";
            FrogTrivia = new Trivia(FrogQuestion, "Golden Poison Frog");

            string MonkeyQuestion = "4. This small cute monkey is in the movie Madagascar. - Tamarin, Golden Lion Monkey, Galago, Spider Monkey";
            MonkeyTrivia = new Trivia(MonkeyQuestion, "Galago");

            string OtterQuestion = "5. These friendly animals love companionship, and often swim in pairs. - Otter, Seal, Muskrat, Dog";
            OtterTrivia = new Trivia(OtterQuestion, "Otter");

            string SlothQuestion = "6. Without the help of these animals, we would not have avocados. - Bear, Sloth, Lemur, Koala";
            SlothTrivia = new Trivia(SlothQuestion, "Sloth");

            string PenguinQuestion = "7. Popular in Japanese zoos, this cowardly penguin is native to South America. - Royal, Emperor, Humbolt, Giant";
            PenguinTrivia = new Trivia(PenguinQuestion, "Humbolt");

            string CapybaraQuestion = "8. The largest species of rodent, UrbanRescueRanch has two named Gort and Quandale. - Prarie Dog, Hamster, Gerbil, Capybara";
            CapybaraTrivia = new Trivia(CapybaraQuestion, "Capybara");

            string BirdQuestion = "9. Native to Australia, these birds are known for their calls which sounds like laughs. - Cockatoo, kookaburra, Lorikeet, Lyrebird";
            BirdTrivia = new Trivia(BirdQuestion, "Kookaburra");

            string AxolotlQuestion = "10. This popular series of salamander does not go through metamorphosis. - Axolotl, Newt, Mole, Siren";
            AxolotlTrivia = new Trivia(AxolotlQuestion, "Axolotl");
            
        }
        public void Play()
        {
            Title = GameTitle;

            //this is the title page
            //this is a frog lol

            ForegroundColor = ConsoleColor.Green;
            WriteLine("      _e-e_  ");
            WriteLine("     (-._.-)  ");
            WriteLine(". -(  `---'  )-. ");
            WriteLine("  __\\ \\\\\\___/// /__ ");
            WriteLine("'-._.'/M\\ /M\\`._,- ");
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

            //here is where we get the player information

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Hello player, What is your name? ");
            String PlayerName = ReadLine();
            ForegroundColor = ConsoleColor.Blue;
            CurrentPlayer = new Player(PlayerName);
            WriteLine("Hello there, " + PlayerName);
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("I hope you enjoy my Trivia Game.");
            ResetColor();
            ReadKey();
            Clear();

            //reads the questions
            //and displays some fun animal facts, after the player has answered.

            PufferfishTrivia.AskQuestion();
            ForegroundColor= ConsoleColor.Blue;
            WriteLine("There are more than 120 different species of pufferfish!");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            CatTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Palla's cats use their tail as a hand warmer!");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            FrogTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("The golden poison frog is thought to be the most poisonous animal on earth.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            MonkeyTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Galagos are also known as Bush Babies.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            OtterTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Otters lack blubber, but have water resistant fur that keeps them warm");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            SlothTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("Despite their slow movement, sloths are actually great swimmers.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            PenguinTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Humbolt penguin can swim at speeds of 30 mph.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            CapybaraTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Capybaras can stay under water for as long as five minutes.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            BirdTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Kookaburras are known to be friendly towards humans.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            AxolotlTrivia.AskQuestion();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Axolotls can regenerate their body parts.");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ResetColor();
            WriteLine("Press enter twice to end the game and bring up the end screen");
            ReadKey();
            }
        }
    }

