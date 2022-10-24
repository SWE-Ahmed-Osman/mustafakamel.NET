namespace Portfolio.DTOs;

public class AboutExperienceDto
{
    public AboutJobDto Job { get; init; } = null!;
    public HomeCompanyDto Company { get; init; } = null!;
    
    public bool Main { get; init; }

    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}