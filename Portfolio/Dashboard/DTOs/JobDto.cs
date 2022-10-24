namespace Portfolio.Dashboard.DTOs;

public class JobDto
{
    public string? Description { get; init; }
    public string Type { get; init; } = null!;
    public string Title { get; init; } = null!;
}