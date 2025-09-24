using EnglishSelfHelpGuide.Data;

using Microsoft.EntityFrameworkCore;

namespace EnglishSelfHelpGuide.Models
{
  
    public class WordService : IWordService
    {
        private readonly ApplicationDbContext _context;

        public WordService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Word>> GetAllWordsAsync()
        {
            return await _context.Words.ToListAsync();
        }

        public async Task AddWordAsync(Word word)
        {
            _context.Words.Add(word);
            await _context.SaveChangesAsync();
        }

        public async Task<Word> FindWordByMeaningAsync(string meaning)
        {
            return await _context.Words.FirstOrDefaultAsync(w => w.RussianMeaning == meaning);
        }
    }
}
