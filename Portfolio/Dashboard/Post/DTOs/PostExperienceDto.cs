using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostExperienceDto
{
    [Required] public int ResumeModelId { get; init; }
    [Required] public int CompanyModelId { get; init; }
    
    public string? Description { get; init; }
    [Required] public int Type { get; init; }
    [Required] public bool Main { get; init; }
    [Required, StringLength(100)] public string Title { get; init; } = null!;

    [Required] public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}