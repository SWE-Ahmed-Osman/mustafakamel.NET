using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Education
{
    [Key] public int Id { get; init; }

    public double Grade { get; set; }
    [StringLength(50)] public string Degree { get; set; } = null!;
    public string? Description { get; set; }
    
    public School School { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}