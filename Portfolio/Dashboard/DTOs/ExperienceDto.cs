namespace Portfolio.Dashboard.DTOs;

public class ExperienceDto
{
    public JobDto Job { get; init; } = null!;
    public CompanyDto Company { get; init; } = null!;
    
    public bool Main { get; init; }

    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}