namespace Portfolio.Dashboard.DTOs;

public class CompanyDto
{
    public string Url { get; init; } = null!;
    public string Name { get; init; } = null!;
    public LocationDto Location { get; init; } = null!;
}