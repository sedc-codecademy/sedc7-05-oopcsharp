using System;
using System.Collections.Generic;

namespace SEDC.Millionaire.Library
{
    public class HelpOption
    {
        public string Name { get; set; }
        public bool IsUsed { get; set; }
        protected Random rnd;
        public HelpOption()
        {
            this.IsUsed = false;
        }
        public HelpOption(string name, Random rnd) : this()
        {
            this.Name = name;
            this.rnd = rnd;
        }

        public virtual void UseHelpOption(Question q, Dictionary<string, int> answerChoices)
        {
            this.IsUsed = true;
            Console.WriteLine("UseHelpOption Method should be overridden");
        }
    }
}
