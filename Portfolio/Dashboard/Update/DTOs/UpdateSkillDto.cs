using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Update.DTOs;

public class UpdateSkillDto
{
    [Required] public int Id { get; init; }
    
    public string? Description { get; init; }
    [Required] public int Type { get; init; }
    [Required, StringLength(50)] public string Name { get; init; } = null!;
}