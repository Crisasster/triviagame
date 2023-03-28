using System;
using System.Collections.Generic;
using System.Linq;
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
            Clear();


            var CurrentPlayer = playerAnswer;

            if (Answer == playerAnswer)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Correct!");
                ResetColor();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Not correct try again :( ");
                ResetColor();
            }

            var Score = Answer;
            {

            }
        }
    }
}
