using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Millionaire.Library
{
    public class HelpFiftyFifty : HelpOption
    {
        public HelpFiftyFifty(Random rnd) : base("50:50", rnd)
        {
        }
        public override void UseHelpOption(Question question, Dictionary<string, int> answerChoices)
        {
            if (IsUsed == false)
            {
                IsUsed = true;
                int answer = rnd.Next(question.PossibleAnswers.Count());
                int fifty = question.PossibleAnswers.Count() / 2;

                int removed = 0;
                for (int i = 0; i < question.PossibleAnswers.Length; i++)
                {
                    if (removed < fifty && question.CheckIsCorrectAnswer(i))
                    {
                        question.PossibleAnswers[i] = "";
                        removed++;
                    }
                    else
                    {
                        string answerLetter = answerChoices
                            .FirstOrDefault(x => x.Value == i)
                            .Key;
                        Console.WriteLine($"{answerLetter}) {question.PossibleAnswers[i]}");
                    }
                }
            }
        }
    }
}
