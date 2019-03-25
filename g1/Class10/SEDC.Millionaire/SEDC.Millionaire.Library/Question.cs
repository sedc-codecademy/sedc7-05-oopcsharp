namespace SEDC.Millionaire.Library
{
    public class Question
    {
        public string Text { get; set; }
        public string[] PossibleAnswers { get; set; }
        private int CorrectAnswer { get; set; }
        public int SelectedAnswer { get; set; }

        public Question()
        {
        }

        public Question(string text, 
            string[] possibleAnswers, 
            int correctAnswer)
        {
            this.Text = text;
            this.PossibleAnswers = possibleAnswers;
            this.CorrectAnswer = correctAnswer;
        }

        public bool CheckIsCorrectAnswer(int selectedAnswer)
        {
            return this.CorrectAnswer == selectedAnswer;
        }

        public int GetCorrectAnswer()
        {
            return this.CorrectAnswer;
        }
    }
}
