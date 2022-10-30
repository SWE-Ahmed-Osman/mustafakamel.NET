using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostSkillDto
{
    [Required] public int ResumeModelId { get; init; }
    
    public string? Description { get; init; }
    [Required] public int Type { get; init; }
    [Required, StringLength(50)] public string Name { get; init; } = null!;
}