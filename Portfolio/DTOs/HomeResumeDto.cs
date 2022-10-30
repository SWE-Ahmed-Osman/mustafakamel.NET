namespace Portfolio.DTOs;

public class HomeResumeDto
{
    public int Id { get; init; }
    
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    public string TitleUrl { get; init; } = null!;
    public string Location { get; init; } = null!;
    
    public HomeExperienceDto Experience { get; init; } = null!;

    public List<HomeProjectDto> LastProjects { get; init; } = null!;
}