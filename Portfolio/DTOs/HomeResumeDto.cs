using Portfolio.Dashboard.DTOs;

namespace Portfolio.DTOs;

public class HomeResumeDto
{
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    public string TitleUrl { get; init; } = null!;
    
    public LocationDto Location { get; init; } = null!;
    public HomeExperienceDto Experience { get; init; } = null!;

    public List<HomeProjectDto> LastProjects { get; init; } = null!;
}