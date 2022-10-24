using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class AboutResumeDto
{
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    public string TitleUrl { get; init; } = null!;
    public string About { get; init; } = null!;
    
    public LocationDto Location { get; init; } = null!;
    
    public int ProjectsCount { get; init; }
    public List<AboutExperienceDto> Experiences { get; } = new();
}