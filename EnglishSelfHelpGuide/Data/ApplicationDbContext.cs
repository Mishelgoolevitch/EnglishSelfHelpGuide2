using EnglishSelfHelpGuide.Models;

using Microsoft.EntityFrameworkCore;

namespace EnglishSelfHelpGuide.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Word> Words { get; set; }
        public required DbSet<IrregularVerb> IrregularVerbs { get; set; }
    }

}
