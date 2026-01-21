using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_InheritanceQuiz
{
    class Question
    {
        protected string _questionText;
        protected string _answerText;

        public Question(string questionText, string answerText)
        {
            _questionText = questionText;
            _answerText = answerText;
        }

        void Ask()
        {
            Console.WriteLine("QuestionText");
        }

        public virtual bool CheckAnswer()
        {
            Console.WriteLine("Enter your answer");

            string playerAnswer = Console.ReadLine();

            if(playerAnswer == _answerText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class MultipleChoiceQuestion: Question
    {
        private string[] _answerOptions;
        private int _correctAnswer;

        public MultipleChoiceQuestion(string questionText, string[] answerOptions, int correctAnswer) : base (questionText, correctAnswer.ToString())
        {
            _questionText = questionText;
            _answerOptions = answerOptions;
            _correctAnswer = correctAnswer;
        }

        public override bool CheckAnswer()
        {
            Console.WriteLine("Enter your answer");

            for (int answers = 0; answers < _answerOptions.Length; answers++)
            {
                Console.WriteLine($"{answers + 1}{_answerOptions[answers]}");
            }

            string playerAnswer = Console.ReadLine();

            if (playerAnswer == _answerText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string questionText, bool answerAsBool) : base (questionText, answerAsBool.ToString())
        {
            _questionText = questionText;
            
        }
    }


}
