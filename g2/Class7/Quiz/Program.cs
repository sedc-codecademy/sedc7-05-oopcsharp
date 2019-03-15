using MyFirstLibrary.Models.QuizModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Question[] QuizQuestions = new Question[11];

            Answer firstAnswer = new Answer("Goran", false);
            Answer secondAnswer = new Answer("Zoran", false);
            Answer thirdAnswer = new Answer("Andrej", false);
            Answer fourthAnswer = new Answer("Igor", true);
            QuizQuestions[0] = new Question("What's my Name?", new Answer[] {
                firstAnswer,
                secondAnswer,
                thirdAnswer,
                fourthAnswer
            });

        }

    }
}
