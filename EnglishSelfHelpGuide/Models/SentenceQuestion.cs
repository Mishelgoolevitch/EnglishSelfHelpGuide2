
using static EnglishSelfHelpGuide.Components.Pages.SentenceQuestion;

namespace EnglishSelfHelpGuide.Models
{
    public class SentenceQuestion : IQuestion
    {
       
            public string Sentence { get; private set; }
            private string[] correctAnswers;
            private string placeholder;

            public SentenceQuestion(string sentence, string[] answers, string placeholder = "_____")
            {
                Sentence = sentence;
                correctAnswers = answers;
                this.placeholder = placeholder;
            }

            public string CurrentSentence => Sentence;

            public string[] GetCorrectAnswers() => correctAnswers;

            public string FillBlank(string word)
            {
                return Sentence.Replace(placeholder, word);
            }

            public bool IsAnswerCorrect(string answer)
            {
                var normalizedAnswer = answer.Trim().ToLower();
                foreach (var correct in correctAnswers)
                {
                    if (normalizedAnswer == correct.ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
        
    }
}
