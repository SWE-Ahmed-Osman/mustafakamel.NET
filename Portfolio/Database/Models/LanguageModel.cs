using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class LanguageModel
{
    [Key] public int Id { get; init; }
    public int ResumeModelId { get; set; }
    
    [StringLength(30)] public string Name { get; set; } = null!;
}