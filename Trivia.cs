using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CristinasTriviaGame1
{
    class Trivia
    {
        private string Question;
        private string Answer;
        public int score;

        public Trivia(string triviaQuestion, string triviaAnswer)
        {
            Question = triviaQuestion;
            Answer = triviaAnswer;
        }

        public void AskQuestion()
        {
            //this will display the questions
            WriteLine(Question);
            Write("What's your answer ");
            string playerAnswer = ReadLine();
            WriteLine("You answered " + playerAnswer);
            WriteLine("The correct answer was: " + Answer);
            bool wrongAnswer = false;
            Clear();

            var CurrentPlayer = playerAnswer;

            // Gives player right or wrong answer

            if  (Answer == playerAnswer)
            {
                ForegroundColor = ConsoleColor.Green;
                score = +1;
                WriteLine("You answered " + playerAnswer);
                WriteLine("Correct!");
                ResetColor();
            }
            else
             {
                
                ForegroundColor = ConsoleColor.Red;
                wrongAnswer = false;
                score = -1;
                WriteLine("You answered " + playerAnswer);
                WriteLine("Sorry, The correct answer was: " + Answer);
                WriteLine(":( ");
                ResetColor();
            }
            while (wrongAnswer)
            {
                Write( Answer + playerAnswer);
                Answer = ReadLine();
                if (Answer == playerAnswer)
                { 
                }

                ReadKey();
            }
        }
    }
}