using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class EducationModel
{
    [Key] public int Id { get; init; }
    public int ResumeModelId { get; set; }
    
    public double Grade { get; set; }
    public string? Description { get; set; }
    [StringLength(100)] public string Degree { get; set; } = null!;

    public int SchoolModelId { get; set; }
    public SchoolModel School { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}