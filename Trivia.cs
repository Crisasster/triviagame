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

            var CurrentPlayer = playerAnswer;

            if (Answer == playerAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Not correct try again :( ");
            }
        }
    }
}
