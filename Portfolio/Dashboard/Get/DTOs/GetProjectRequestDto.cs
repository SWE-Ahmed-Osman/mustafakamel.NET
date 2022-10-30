namespace Portfolio.Dashboard.Get.DTOs;

public class GetProjectRequestDto
{
    public int Id { get; init; }
    
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
    
    public int Type { get; set; }
    public int Category { get; set; }
    public string Description { get; set; } = null!;
    
    public int Budget { get; set; }
    public int Timeline { get; set; }
    
    public string PdfUrl { get; set; } = null!;
}