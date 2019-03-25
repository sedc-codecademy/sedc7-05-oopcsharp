using SEDC.Millionaire.Library;
using System;

namespace SEDC.Millionaire.App
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizMillionaire quizMillionaire = new QuizMillionaire();
            #region PossibleQuestionsList
            int possibleQuestionsCount = 100;
            for (int i = 0; i < possibleQuestionsCount; i++)
            {
                Question question = new Question($"Question{i}-{i%4}", new string[4] { "Answer0", "Answer1", "Answer2", "Answer3" }, i % 4);
                quizMillionaire.PossibleQuestions.Add(question);
            }
            #endregion

            quizMillionaire.Start();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
