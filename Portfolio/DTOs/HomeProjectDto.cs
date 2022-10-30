namespace Portfolio.DTOs;

public class HomeProjectDto
{
    public int Id { get; init; }
    
    public int Type { get; init; }
    public int Category { get; init; }
    public string Name { get; init; } = null!;
    
    public string DarkImageUrl { get; init; } = null!;
    public string LightImageUrl { get; init; } = null!;
}