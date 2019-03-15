using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary.Models.QuizModels
{
    public class Answer
    {
        public string Content { get; set; }
        public bool IsTrue { get; set; }

        public Answer(string content, bool isTrue)
        {
            Content = content;
            IsTrue = isTrue;
        }
    }
}
