using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Update.DTOs;

public class UpdateEducationDto
{
    [Required] public int Id { get; init; }
    
    [Required] public double Grade { get; init; }
    [Required] public string? Description { get; init; }
    [Required, StringLength(100)] public string Degree { get; init; } = null!;
    
    [Required] public int SchoolModelId { get; init; }

    [Required] public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}