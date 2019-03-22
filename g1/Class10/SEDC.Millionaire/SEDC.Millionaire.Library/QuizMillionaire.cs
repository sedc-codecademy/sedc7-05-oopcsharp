using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Millionaire.Library
{
    public class QuizMillionaire : Quiz
    {
        private Random rnd;
        private Question[] questions15;
        private Dictionary<string, int> answerChoices;
        private HelpAudience hAA;
        private HelpFriend hCF;
        private HelpFiftyFifty hFF;

        public QuizMillionaire() : base("Millionaire")
        {
            this.rnd = new Random();
            this.questions15 = new Question[15];
            this.answerChoices = new Dictionary<string, int>();
            this.answerChoices.Add("A", 0);
            this.answerChoices.Add("B", 1);
            this.answerChoices.Add("C", 2);
            this.answerChoices.Add("D", 3);
            this.hAA = new HelpAudience(rnd);
            this.hCF = new HelpFriend(rnd);
            this.hFF = new HelpFiftyFifty(rnd);
        }

        private void GenerateQuestion15()
        {
            ShufflePossibleQuestions();
            questions15 = PossibleQuestions
                .Take(15)
                .ToArray();
        }

        public override void Start()
        {
            try
            {
                GenerateQuestion15();
                int i = 0;
                while (i < questions15.Length)
                {
                    Question question = questions15[i];
                    PrintQuestion(i, question);
                    PrintHelpOptions();

                    Console.WriteLine("Answer = ");
                    string answer = Console.ReadLine().ToUpper();
                    if (answerChoices.ContainsKey(answer))
                    {
                        question.SelectedAnswer = answerChoices[answer];
                        if (!question.CheckIsCorrectAnswer(answerChoices[answer]))
                        {
                            break;
                        }
                        i++;
                        Console.Clear();
                    }
                    else
                    {
                        switch (answer)
                        {
                            case "HAA":
                                hAA.UseHelpOption(question, answerChoices);
                                break;
                            case "HCF":
                                hCF.UseHelpOption(question, answerChoices);
                                break;
                            case "HFF":
                                hFF.UseHelpOption(question, answerChoices);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                    }
                }
                if (i == questions15.Length)
                {
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Congratulations You are a Millionaire");
                }
                else
                {
                    int correctAnswer = questions15[i].GetCorrectAnswer();
                    string correctAnswerLetter = answerChoices
                        .FirstOrDefault(x => x.Value == correctAnswer)
                        .Key;
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"GAME OVER. CorrectAnswer = {correctAnswerLetter}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PrintQuestion(int questionNumber, Question question)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Question {questionNumber + 1}: {question.Text}");

            for (int i = 0; i < question.PossibleAnswers.Length; i++)
            {
                string answerLetter = answerChoices
                    .FirstOrDefault(x => x.Value == i)
                    .Key;
                Console.WriteLine($"{answerLetter}) {question.PossibleAnswers[i]}");
            }
        }

        private void ShufflePossibleQuestions()
        {
            int n = PossibleQuestions.Count;
            while (n > 1)
            {
                n--;
                int randomNumber = rnd.Next(n + 1);
                Question temp = PossibleQuestions[randomNumber];
                PossibleQuestions[randomNumber] = PossibleQuestions[n];
                PossibleQuestions[n] = temp;
            }
        }

        private void PrintHelpOptions()
        {
            Console.WriteLine($"HAA) {hAA.Name} - IsUsed = {hAA.IsUsed}");
            Console.WriteLine($"HCF) {hCF.Name} - IsUsed = {hCF.IsUsed}");
            Console.WriteLine($"HFF) {hFF.Name} - IsUsed = {hFF.IsUsed}");
        }
    }
}
