using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Job
{
    [Key] public int Id { get; init; }
    
    [StringLength(50)] public string Title { get; set; } = null!;
    [StringLength(30)] public EmploymentType Type { get; set; }
    public string? Description { get; set; }
}

public enum EmploymentType
{
    FullTime,
    PartTime,
    SelfEmployed,
    Freelance,
    Contract,
    Internship,
    Apprenticeship,
    Seasonal
}