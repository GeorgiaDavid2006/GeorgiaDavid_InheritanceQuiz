using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_InheritanceQuiz
{
    internal class Program
    {
        static string[] quizQuestions =
        {
            "Question 1",
            "Question 2",
            "Question 3",
            "Question 4",
            "Question 5",
            "Question 6",
            "Question 7",
            "Question 8",
            "Question 9"
        };

        static string[] textAnswers =
        {
            "Text Answer 1",
            "Text Answer 2",
            "Text Answer 3"
        };

        static string[] multipleChoiceAnswers1 =
        {
            "Multiple Choice Answer 1",
            "Multiple Choice Answer 2",
            "Multiple Choice Answer 3",
            "Multiple Choice Answer 4"
        };

        static string[] multipleChoiceAnswers2 =
        {
            "Multiple Choice Answer 1",
            "Multiple Choice Answer 2",
            "Multiple Choice Answer 3",
            "Multiple Choice Answer 4"
        };

        static string[] multipleChoiceAnswers3 =
        {
            "Multiple Choice Answer 1",
            "Multiple Choice Answer 2",
            "Multiple Choice Answer 3",
            "Multiple Choice Answer 4"
        };

        static int score = 0;

        static void Main(string[] args)
        {
           Question question1 = new Question(quizQuestions[0], textAnswers[0]);
           Question question2 = new Question(quizQuestions[1], textAnswers[1]);
           Question question3 = new Question(quizQuestions[2], textAnswers[2]);
           MultipleChoiceQuestion question4 = new MultipleChoiceQuestion(quizQuestions[3], multipleChoiceAnswers1, 2);
           MultipleChoiceQuestion question5 = new MultipleChoiceQuestion(quizQuestions[4], multipleChoiceAnswers2, 3);
           MultipleChoiceQuestion question6 = new MultipleChoiceQuestion(quizQuestions[5], multipleChoiceAnswers3, 4);
           TrueOrFalseQuestion question7 = new TrueOrFalseQuestion(quizQuestions[6], true);
           TrueOrFalseQuestion question8 = new TrueOrFalseQuestion(quizQuestions[7], false);
           TrueOrFalseQuestion question9 = new TrueOrFalseQuestion(quizQuestions[8], true);

           Console.WriteLine("Welcome to the Kirby Lore Quiz");
           Console.ReadKey();
           Console.Clear();

           AskQuestion();
        }

        static void AskQuestion()
        {
            for (int question = 0; question < quizQuestions.Length; question++)
            {
                
            }
        }
    }
}
