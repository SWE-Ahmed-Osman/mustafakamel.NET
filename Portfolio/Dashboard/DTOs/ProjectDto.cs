namespace Portfolio.Dashboard.DTOs;

public class ProjectDto
{
    public int Id { get; init; }
    public bool ForSale { get; init; }
    public string Name { get; init; } = null!;
    public string Type { get; init; } = null!;
    public string ImageUrl { get; init; } = null!;
}