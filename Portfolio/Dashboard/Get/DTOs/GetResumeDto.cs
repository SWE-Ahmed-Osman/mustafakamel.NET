namespace Portfolio.Dashboard.Get.DTOs;

public class GetResumeDto
{
    public int Id { get; init; }
    
    public string About { get; init; } = null!;
    public string TitleUrl { get; init; } = null!;
    public string ResumeUrl { get; init; } = null!;
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    public string Location { get; init; } = null!;
    
    public List<GetSkillDto> Skills { get; init; } = null!;
    public List<GetProjectDto> Projects { get; init; } = null!;
    public List<GetLanguageDto> Languages { get; init; } = null!;
    public List<GetEducationDto> Educations { get; init; } = null!;
    public List<GetExperienceDto> Experiences { get; init; } = null!;
}