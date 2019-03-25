using System.Collections.Generic;

namespace SEDC.Millionaire.Library
{
    public class Quiz
    {
        public string Name { get; set; }
        public List<Question> PossibleQuestions { get; set; }

        public Quiz()
        {
            this.PossibleQuestions = new List<Question>();
        }

        public Quiz(string name) :this()
        {
            this.Name = name;
        }

        public virtual void Start()
        {
            System.Console.WriteLine("Quiz Start Method should be overridden");
        }
    }
}
