using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Post.DTOs;

public class PostEducationDto
{
    [Required] public int ResumeModelId { get; init; }
    [Required] public int SchoolModelId { get; init; }
    
    [Required] public double Grade { get; init; }
    [Required] public string? Description { get; init; }
    [Required, StringLength(100)] public string Degree { get; init; } = null!;

    [Required] public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}