namespace Portfolio.Dashboard.Get.DTOs;

public class GetFeedbackDto
{
    public int Id { get; init; }
    
    public string Description { get; init; } = null!;
    public string Name { get; init; } = null!;
    public string Title { get; init; } = null!;

    public bool Reviewed { get; init; }
    public bool Workmate { get; init; }

    public int? Feeling { get; init; }
    public string? ImageUrl { get; init; }
}