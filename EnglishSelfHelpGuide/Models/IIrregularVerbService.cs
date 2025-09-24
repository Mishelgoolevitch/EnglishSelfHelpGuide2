
namespace EnglishSelfHelpGuide.Models
{
   
    public interface IIrregularVerbService
    {
        Task<IEnumerable<IrregularVerb>> GetAllIrregularVerbsAsync();
        Task AddIrregularVerbAsync(IrregularVerb verb);
        Task<IrregularVerb> FindIrregularVerbAsync(string baseForm);
    }
}

