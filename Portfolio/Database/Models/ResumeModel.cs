using System.ComponentModel.DataAnnotations;

namespace Portfolio.Database.Models;

public class ResumeModel
{
    [Key] public int Id { get; init; }
    [EmailAddress] public string ProfileModelEmail { get; set; } = null!;

    public string About { get; set; } = null!;
    public string TitleUrl { get; set; } = null!;
    [StringLength(50)] public string Name { get; set; } = null!;
    [StringLength(100)] public string Title { get; set; } = null!;
    [StringLength(50)] public string Location { get; set; } = null!;
    
    public string ResumeUrl { get; set; } = null!;
    public string ResumeName { get; set; } = null!;

    public List<SkillModel> Skills { get; } = new();
    public List<ProjectModel> Projects { get; } = new();
    public List<LanguageModel> Languages { get; } = new();
    public List<EducationModel> Educations { get; } = new();
    public List<ExperienceModel> Experiences { get; } = new();
}