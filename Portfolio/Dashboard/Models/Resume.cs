using System.ComponentModel.DataAnnotations;

namespace Portfolio.Dashboard.Models;

public class Resume
{
    [Key] public int Id { get; init; }

    [StringLength(100)] public string Name { get; set; } = null!;
    [StringLength(50)] public string Title { get; set; } = null!;
    public string TitleUrl { get; set; } = null!;
    public string ResumeUrl { get; set; } = null!;
    public Location Location { get; set; } = null!;
    public string About { get; set; } = null!;

    public List<Skill> Skills { get; } = new();
    public List<Project> Projects { get; } = new();
    public List<Language> Languages { get; } = new();
    public List<Education> Educations { get; } = new();
    public List<Experience> Experiences { get; } = new();
}