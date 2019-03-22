using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Millionaire.Library
{
    public class HelpFriend : HelpOption
    {
        public HelpFriend(Random rnd) : base("Call a Friend", rnd)
        {

        }
        public override void UseHelpOption(Question question, Dictionary<string, int> answerChoices)
        {
            if (IsUsed == false)
            {
                IsUsed = true;
                int rndNumber = rnd.Next(question.PossibleAnswers.Where(x => x != "").Count());
                int rndNumberIterator = 0;
                for (int i = 0; i < question.PossibleAnswers.Count(); i++)
                {
                    if (question.PossibleAnswers[i] != "")
                    {
                        if (rndNumberIterator == rndNumber)
                        {
                            string answerLetter = answerChoices
                                .FirstOrDefault(x => x.Value == i)
                                .Key;
                            Console.WriteLine($"Friend answer: {answerLetter}) {question.PossibleAnswers[i]}");
                            break;
                        }
                        else
                        {
                            rndNumberIterator++;
                        }

                    }
                }
            }
        }
    }
}
