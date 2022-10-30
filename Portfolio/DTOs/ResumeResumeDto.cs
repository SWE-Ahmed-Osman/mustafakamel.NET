using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.DTOs;

public class ResumeResumeDto
{
    public int Id { get; init; }
    
    public string Name { get; init; } = null!;
    public string ResumeUrl { get; init; } = null!;

    public List<GetSkillDto> Skills { get; init; } = null!;
    public List<GetLanguageDto> Languages { get; init; } = null!;
    public List<GetEducationDto> Educations { get; init; } = null!;
    public List<GetExperienceDto> Experiences { get; init; } = null!;
}