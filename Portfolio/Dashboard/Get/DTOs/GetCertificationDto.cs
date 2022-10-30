namespace Portfolio.Dashboard.Get.DTOs;

public class GetCertificationDto
{
    public int Id { get; init; }
    
    public string Url { get; init; } = null!;
    public string Name { get; init; } = null!;
    public string Issuer { get; init; } = null!;
}