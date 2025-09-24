using System.ComponentModel.DataAnnotations;

namespace EnglishSelfHelpGuide.Models
{
    public  class IrregularVerb
    {
        
        public int Id { get; set; }
        public string? BaseForm { get; set; }
        public string? PastSimple { get; set; }
        public string? PastParticiple { get; set; }
    }
}
