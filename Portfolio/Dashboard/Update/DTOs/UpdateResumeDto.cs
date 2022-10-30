using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Update.DTOs;

public class UpdateResumeDto
{
    [Required] public int Id { get; init; }
    
    [Required] public string About { get; init; } = null!;
    [Required] public string TitleUrl { get; init; } = null!;
    [Required, StringLength(50)] public string Name { get; init; } = null!;
    [Required, StringLength(100)] public string Title { get; init; } = null!;
    [Required, StringLength(50)] public string Location { get; init; } = null!;
}