namespace Portfolio.Dashboard.DTOs;

public class EducationDto
{
    public double Grade { get; init; }
    public string? Description { get; init; }
    public string Degree { get; init; } = null!;
    
    public SchoolDto School { get; init; } = null!;

    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}