namespace Portfolio.DTOs;

public class HomeProjectDto
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string Type { get; init; } = null!;
    public string ImageUrl { get; init; } = null!;
}