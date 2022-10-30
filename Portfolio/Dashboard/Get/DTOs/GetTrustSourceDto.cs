namespace Portfolio.Dashboard.Get.DTOs;

public class GetTrustSourceDto
{
    public int Id { get; init; }
    
    public string Url { get; init; } = null!;
    public string ImageUrl { get; init; } = null!;
}