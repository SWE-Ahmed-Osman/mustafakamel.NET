using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class ResumeResumeDto
{
    public string Name { get; init; } = null!;
    public string ResumeUrl { get; init; } = null!;
    
    public List<SkillDto> Skills { get; } = new();
    public List<LanguageDto> Languages { get; } = new();
    public List<EducationDto> Educations { get; } = new();
    public List<ExperienceDto> Experiences { get; } = new();
}