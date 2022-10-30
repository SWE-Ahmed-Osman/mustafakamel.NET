namespace Portfolio.Dashboard.Get.DTOs;

public class GetEducationDto
{
    public int Id { get; init; }
    
    public double Grade { get; init; }
    public string? Description { get; init; }
    public string Degree { get; init; } = null!;
    
    public GetSchoolDto School { get; init; } = null!;

    public DateTime StartDate { get; init; }
    public DateTime? EndDate { get; init; }
}