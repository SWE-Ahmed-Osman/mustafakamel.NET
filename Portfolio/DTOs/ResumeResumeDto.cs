using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class ResumeResumeDto
{
    public string Name { get; init; } = null!;
    public string ResumeUrl { get; init; } = null!;

    public List<SkillDto> Skills { get; init; } = null!;
    public List<LanguageDto> Languages { get; init; } = null!;
    public List<EducationDto> Educations { get; init; } = null!;
    public List<ExperienceDto> Experiences { get; init; } = null!;
}