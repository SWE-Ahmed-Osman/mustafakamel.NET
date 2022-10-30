namespace Portfolio.Dashboard.Get.DTOs;

public class GetExperienceDto
{
    public int Id { get; init; }
    
    public int Type { get; init; }
    public bool Main { get; init; }
    public string? Description { get; init; }
    public string Title { get; init; } = null!;
    
    public GetCompanyDto Company { get; init; } = null!;

    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}