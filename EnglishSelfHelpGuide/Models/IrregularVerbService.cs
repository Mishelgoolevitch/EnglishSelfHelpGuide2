using EnglishSelfHelpGuide.Data;

using Microsoft.EntityFrameworkCore;

namespace EnglishSelfHelpGuide.Models
{
   
    public class IrregularVerbService : IIrregularVerbService
    {
        private readonly ApplicationDbContext _context;

        public IrregularVerbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IrregularVerb>> GetAllIrregularVerbsAsync()
        {
            return await _context.IrregularVerbs.ToListAsync();
        }

        public async Task AddIrregularVerbAsync(IrregularVerb verb)
        {
            _context.IrregularVerbs.Add(verb);
            await _context.SaveChangesAsync();
        }

        public async Task<IrregularVerb> FindIrregularVerbAsync(string baseForm)
        {
            return await _context.IrregularVerbs.FirstOrDefaultAsync(v => v.BaseForm == baseForm);
        }
    }
}

