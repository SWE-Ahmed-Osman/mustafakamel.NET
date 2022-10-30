namespace Portfolio.DTOs;

public class HomeFeedbackDto
{
    public int Id { get; init; }
    
    public string Description { get; init; } = null!;
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;
    
    public int? Feeling { get; init; }
    public string? ImageUrl { get; init; }
}