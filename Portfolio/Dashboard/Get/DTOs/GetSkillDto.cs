namespace Portfolio.Dashboard.Get.DTOs;

public class GetSkillDto
{
    public int Id { get; init; }
    
    public int Type { get; init; }
    public string? Description { get; init; }
    public string Name { get; init; } = null!;
}