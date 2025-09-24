   
    using System.ComponentModel.DataAnnotations;


    namespace EnglishSelfHelpGuide.Models
    {
    public class Word
    {
        
        public int Id { get; set; }
        public string? EnglishWord { get; set; }
        public string? RussianMeaning { get; set; }

    }
    }


