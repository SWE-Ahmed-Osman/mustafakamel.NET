namespace Portfolio.Dashboard.DTOs;

public class FeedbackDto
{
    public string? ImageUrl { get; init; }
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    public string Feeling { get; init; } = null!;
    public string Description { get; init; } = null!;
}