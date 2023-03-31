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

            //Gives player right or wrong answer

            var CurrentPlayer = playerAnswer;

            if  (Answer == playerAnswer)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("You answered " + playerAnswer);
                WriteLine("Correct!");
                ResetColor();
            }
            else
             {
                
                ForegroundColor = ConsoleColor.Red;
                wrongAnswer = false;
                WriteLine("You answered " + playerAnswer);
                WriteLine("Sorry, The correct answer was: " + Answer);
                WriteLine(":( ");
                ResetColor();
            }

            //makes the next question appear if the play answers wrong
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