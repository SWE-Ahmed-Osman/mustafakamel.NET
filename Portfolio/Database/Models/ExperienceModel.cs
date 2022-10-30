using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class ExperienceModel
{
    [Key] public int Id { get; init; }
    public int ResumeModelId { get; set; }

    [StringLength(100)] public string Title { get; set; } = null!;
    public EmploymentType Type { get; set; }
    public string? Description { get; set; }

    public bool Main { get; set; }
    public bool IsMain() => Main;

    public int CompanyModelId { get; set; }
    public CompanyModel Company { get; set; } = null!;

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
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