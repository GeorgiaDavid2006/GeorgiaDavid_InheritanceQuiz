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

    static Question[] questions = 
        {
            question1 = new Question(quizQuestions[0], textAnswers[0]),
            question2 = new Question(quizQuestions[1], textAnswers[1]),
            question3 = new Question(quizQuestions[2], textAnswers[2]),
            question4 = new MultipleChoiceQuestion(quizQuestions[3], multipleChoiceAnswers1, 2),
            question5 = new MultipleChoiceQuestion(quizQuestions[4], multipleChoiceAnswers2, 3),
            question6 = new MultipleChoiceQuestion(quizQuestions[5], multipleChoiceAnswers3, 4),
            question7 = new TrueOrFalseQuestion(quizQuestions[6], true),
            question8 = new TrueOrFalseQuestion(quizQuestions[7], false),
            question9 = new TrueOrFalseQuestion(quizQuestions[8], true)

        };

        static int score = 0;

        static Question question1;
        static Question question2;
        static Question question3;
        static MultipleChoiceQuestion question4;
        static MultipleChoiceQuestion question5;
        static MultipleChoiceQuestion question6;
        static TrueOrFalseQuestion question7;
        static TrueOrFalseQuestion question8;
        static TrueOrFalseQuestion question9;

        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to the Kirby Lore Quiz");
           Console.ReadKey();
           Console.Clear();

           AskQuestion(0);
        }

        static void AskQuestion(int currentQuestion)
        {
            questions[currentQuestion].Ask();
            questions[currentQuestion].CheckAnswer();
        }
    }
}
