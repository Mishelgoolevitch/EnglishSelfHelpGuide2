


namespace EnglishSelfHelpGuide.Models
{
    public interface IWordService
    {
        Task<IEnumerable<Word>> GetAllWordsAsync();
        Task AddWordAsync(Word word);
        Task<Word> FindWordByMeaningAsync(string meaning);
    }
}

