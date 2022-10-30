using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class SkillModel
{
    [Key] public int Id { get; init; }
    public int ResumeModelId { get; set; }
    
    public SkillType Type { get; set; }
    public string? Description { get; set; }
    [StringLength(50)] public string Name { get; set; } = null!;
}

public enum SkillType
{
    Hard,
    Soft,
    Personal,
    Transferable,
    KnowledgeBased
}