using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_InheritanceQuiz
{
    internal class Program
    {
        static string[] quizQuestions =
        {
            "What is the name of the planet Kirby lives on?",
            "What is Kirby's favourite food?",
            "How tall is Kirby in centimeters?",
            "Which is NOT the name of one of the three mage sisters?",
            "Who is the final boss of Kirby's Adventure(1993)?",
            "Elfilin is the other half of the being known as...",
            "Galacta Knight was one of the Four Heroes of Yore",
            "Marx is the name of the character who betrays Kirby in Kirby's Return To Dreamland",
            "President Haltmann dies at the end Kirby:Planet Robobot"
        };

        static string[] textAnswers =
        {
            "Planet Popstar",
            "Maxim Tomato",
            "8"
        };

        static string[] multipleChoiceAnswers1 =
        {
            "Flamberge",
            "Francessca",
            "Zan Partizanne",
            "Francisca"
        };

        static string[] multipleChoiceAnswers2 =
        {
            "King Dedede",
            "Zero",
            "Nightmare",
            "Kracko"
        };

        static string[] multipleChoiceAnswers3 =
        {
            "Fecto Elfilin",
            "Fecto Forgo",
            "Chaos Elfilis",
            "Fecto Elfilis"
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
           Console.WriteLine("Welcome to the Kirby Triva Quiz");
           Console.ReadKey();
           Console.Clear();

           for (int q = 0; q < quizQuestions.Length; q++)
           {
              AskQuestion(q);
           }

            DisplayScore();
            Console.ReadKey();
            Console.Clear();

            if (score == 9)
            {
                Console.WriteLine("100%! Congratulations!");
                Console.ReadKey();
                Console.Clear();
            }
            else if (score < 9 && score > 0)
            {
                Console.WriteLine("Well done");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AskQuestion(int currentQuestion)
        {
            DisplayScore();

            questions[currentQuestion].Ask();

            if (questions[currentQuestion].CheckAnswer() == true)
            {
                Console.WriteLine("Correct");
                score++;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Incorrect");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DisplayScore()
        {
            Console.WriteLine("Score: " + score);
        }
    }
}
