using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.DTOs;

public class AboutResumeDto
{
    public int Id { get; init; }
    
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    public string About { get; init; } = null!;
    public string TitleUrl { get; init; } = null!;
    public string Location { get; init; } = null!;
    
    public int ProjectsCount { get; init; }
    
    public List<GetExperienceDto> Experiences { get; init; } = null!;
}